using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myChat
{
    public partial class chatClient : Form
    {
        public chatClient()
        {
            InitializeComponent();
        }

        delegate void cbAddText(string str, int i);
        void AddText(string str, int i)
        {
            if (tbServer.InvokeRequired || tbClient.InvokeRequired )
            {
                cbAddText cb = new cbAddText(AddText);
                object[] obj = { str, i };
                Invoke(cb, obj);
            }
            else
            {
                if (i == 1)
                    tbServer.Text += str;
                else if (i == 2)
                    tbClient.Text += str;
            }
        }

        
        Socket sock = null;
        TcpClient[] tcp = new TcpClient[10];
        TcpListener listen = null;
        Thread threadServer = null; 
        Thread threadRead = null;   
        int CurrentClientNum = 0;
        string ConnectIP = "127.0.0.1";
        int ConnectPort = 9000;

 
        void ServerProcess()
        {
            while (true)
            {
                if (listen.Pending())
                {
                    if (CurrentClientNum == 9) break;
                    tcp[CurrentClientNum] = listen.AcceptTcpClient();                  
                    string sLabel = tcp[CurrentClientNum].Client.RemoteEndPoint.ToString();
                    AddText($"Client [{sLabel}] 로부터 접속되었습니다\r\n\r\n", 1);
                    AddText(sLabel, 3);

                    if(threadRead == null)
                    {
                        threadRead = new Thread(ReadProcess);
                        threadRead.Start();
                    }
                    CurrentClientNum++;
                }
                Thread.Sleep(100);
            }
        }        

        void ReadProcess()
        {
            
            byte[] bArr = new byte[512];
            while (true)
            {
                for(int i = 0; i < CurrentClientNum; i++)
                {
                    NetworkStream ns = tcp[i].GetStream();
                    if (ns.DataAvailable)
                    {
                        int n = ns.Read(bArr, 0, 512);
                        AddText(Encoding.Default.GetString(bArr, 0, n), 1);
                    }
                }
                Thread.Sleep(100);
            }
        }

        private void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadServer != null) threadServer.Abort();
            if (threadRead != null) threadRead.Abort();
            if (threadClientRead != null) threadClientRead.Abort();
        }

        Thread threadClientRead = null;
        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sock != null)
                {
                    if (MessageBox.Show("재연결하시겠습니까?.", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        sock.Close();
                        threadClientRead.Abort();
                    }
                }
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Connect(ConnectIP, ConnectPort);

                AddText($"Server [{ConnectIP}:{ConnectPort}] Connected OK.\r\n", 1);
                
                threadClientRead = new Thread(ClientReadProcess);
                threadClientRead.Start();
                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        void ClientReadProcess()
        {
            byte[] bArr = new byte[512];
            while (true)
            {
                if (sock.Available > 0)
                {
                    int n = sock.Receive(bArr);
                    AddText("[답변] : "+$"{Encoding.Default.GetString(bArr, 0, n)}\r\n\r\n", 1);
                }
                Thread.Sleep(100);
            }
        }
             

        private void tbClient_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (sock != null)
                {
                    string SendServer = tbClient.Text + "\r\n";
                    sock.Send(Encoding.Default.GetBytes(SendServer));
                    AddText("[내 문의사항] : " + tbClient.Text + "\r\n", 1);
                    tbClient.Text = "";
                }
            }
        }

        private void sbServerStart_Click(object sender, EventArgs e)
        {
            if (listen != null)
            {
                if (MessageBox.Show("서버를 다시 시작하시겠습니까?.", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    listen.Stop();
                    if (threadServer != null) threadServer.Abort();
                    if (threadRead != null) threadRead.Abort();
                }
            }
            listen = new TcpListener(9000);
            listen.Start();
            AddText($"서버가 [{ConnectPort}] Port에서 시작되었습니다.\r\n\r\n", 1);

            threadServer = new Thread(ServerProcess);
            threadServer.Start();
        }

        
    }
}

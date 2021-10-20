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

        //AddText()를 사용하여 대화창(1), 메세지 입력창(2) 텍스트 추가
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


        private void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadServer != null) threadServer.Abort();
            if (threadRead != null) threadRead.Abort();
            if (threadClientRead != null) threadClientRead.Abort();
        }

        Thread threadClientRead = null;
        
        //버튼을 눌러 일대일 대화창에서 관리자와 사용자를 연결함(재연결 가능)
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

        //관리자가 보낸 답변 내용을 읽어 사용자의 대화창에 전송함
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
             
        //[Enter]키를 누르면 텍스트를 관리자의 대화창과 사용자의 대화창에 전송함
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

        
        
    }
}

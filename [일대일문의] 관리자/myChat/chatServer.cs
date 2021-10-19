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
    public partial class chatServer : Form
    {
        public chatServer()
        {
            InitializeComponent();
        }

        delegate void cbAddText(string str, int i);
        void AddText(string str, int i)
        {
            if (tbServer.InvokeRequired || tbClient.InvokeRequired ||statusStrip1.InvokeRequired)
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
                else if (i == 3)
                    sbClientList.DropDownItems.Add(str);
            }
        }
        class TcpEx
        {
            public TcpClient tp;
            public string id;
            public TcpEx(TcpClient t, string s)
            {
                tp = t;
                id = s;
            }
        }

        
        Socket sock = null;
        TcpClient[] tcp = new TcpClient[100];
        TcpListener listen = null;
        Thread threadServer = null; // Connect 요구 처리 쓰레드
        Thread threadRead = null;   // 입력 문자열 처리 쓰레드
        int CurrentClientNum = 0;
        int ServerPort = 9000;

        string[] sname = new string[100];
        void ServerProcess()// Connect 요구 처리 쓰레드
        {
            while (true)
            {
                if (listen.Pending())
                {
                    if (CurrentClientNum == 99) break;
                    tcp[CurrentClientNum] = listen.AcceptTcpClient(); // 세션 수립                    
                    string sLabel = tcp[CurrentClientNum].Client.RemoteEndPoint.ToString();
                    AddText($"Client [{sLabel}] 로부터 접속되었습니다\r\n\r\n", 1);
                    AddText(sLabel, 3);
                    sbClientList.Text = sLabel;
                    
                    sname[CurrentClientNum] = tcp[CurrentClientNum].Client.RemoteEndPoint.ToString();

                    if (threadRead == null)
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
                    string snn = sname[i];
                    if (ns.DataAvailable)
                    {                        
                        int n = ns.Read(bArr, 0, 512);
                        AddText($"[{snn}] : {Encoding.Default.GetString(bArr, 0, n)}", 1);
                    }
                }
                Thread.Sleep(100);
            }
        }

        private void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadServer != null) threadServer.Abort();
            if (threadRead != null) threadRead.Abort();
        }

        void ClientReadProcess()
        {
            byte[] bArr = new byte[512];
            while (true)
            {
                if (sock.Available > 0)
                {
                    int n = sock.Receive(bArr);
                    AddText($"{Encoding.Default.GetString(bArr, 0, n)}", 2);
                }
                Thread.Sleep(100);
            }
        }
             

        private void tbClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int j = 0;
                for(int i = 0; i < CurrentClientNum; i++)
                {
                    if (tcp[i].Client.RemoteEndPoint.ToString() == sbClientList.Text)
                        j = i;
                }
                tcp[j].Client.Send(Encoding.Default.GetBytes(tbClient.Text+"\r\n"));
                string sn = sname[j];
                AddText($"[{sn} 답변] : {tbClient.Text}", 1);
                tbClient.Text = "";
            }
        }

        private void pmnuServerStart_Click(object sender, EventArgs e)
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
            listen = new TcpListener(ServerPort);
            listen.Start();
            AddText($"서버가 [{ServerPort}] Port에서 시작되었습니다.\r\n\r\n", 1);

            threadServer = new Thread(ServerProcess);
            threadServer.Start();
        }

        private void sbClientList_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            sbClientList.Text = e.ClickedItem.Text;
        }
    }
}

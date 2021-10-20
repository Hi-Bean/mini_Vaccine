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
        //AddText()를 사용하여 대화창(1), 메세지 입력창(2), Statusstrip(3)에 선택하여 텍스트 추가 
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

        //사용자들마다 고유 번호를 부여하기 위해 string 배열 사용
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
        
        // 사용자 보낸 텍스트를 읽어오는 작업
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

        
        //[Enter]키를 누르면 텍스트를 관리자의 대화창과 사용자의 대화창에 전송함
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
        //메세지 입력창에서 [오른쪽 버튼] - [ServerStart] 서버를 시작하는 기능
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

        //원하는 사용자를 선택해 해당 사용자에게만 답변을 보낼 수 있음
        private void sbClientList_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            sbClientList.Text = e.ClickedItem.Text;
        }
    }
}

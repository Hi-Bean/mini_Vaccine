using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProject_Vaccine
{
    public partial class frmAppointment : Form
    {
        string Chname = ""; int year, month, day;
        string sqlPath = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30";

        public frmAppointment(string hosName, int y, int m, int d)
        {
            InitializeComponent();
            cbVaccine.Items.Add("AZ");
            cbVaccine.Items.Add("얀센");
            cbVaccine.Items.Add("화이자");
            cbVaccine.Items.Add("모더나");
            
            Chname = hosName;
            lbHospital.Text = Chname;

            //오늘 날짜 저장
            year = y; month = m; day = d;

            btnOk.Visible = true;
            btnRevice.Visible = false;

            this.Text = "백신 예약";

            label10.Visible = false;
            lbSuccess.Visible = false;
        }


        // 예약 수정을 위한 생성자
        string rName, rPW, prevVaccine, prevhname, prevDate;
        int prevS;
        public frmAppointment(string name, string pw, int y, int m, int d)
        {
            InitializeComponent();
            cbVaccine.Items.Add("AZ");
            cbVaccine.Items.Add("얀센");
            cbVaccine.Items.Add("화이자");
            cbVaccine.Items.Add("모더나");

            //오늘 날짜 저장
            year = y; month = m; day = d;

            btnOk.Visible = false;
            btnRevice.Visible = true;

            rName = name; rPW = pw;
            this.Text = "예약 정보 수정";

            SqlDB sqldb = new SqlDB(sqlPath);
            string sql = $"select * from patient where name = N'{rName}' and pw = N'{rPW}'";

            DataTable dt = (DataTable)sqldb.Run(sql);
            prevhname = dt.Rows[0][2].ToString();
            prevVaccine = dt.Rows[0][3].ToString();
            prevDate = dt.Rows[0][4].ToString();
            //prevArea = dt.Rows[0][5].ToString();
            //prevPhone = dt.Rows[0][6].ToString();
            //prevRegisterNum = dt.Rows[0][7].ToString();

            tbId.Text = rName;
            tbPw.Text = rPW;
            cbVaccine.Text = dt.Rows[0][3].ToString();
            lbHospital.Text = dt.Rows[0][2].ToString();
            dtDate.Text = dt.Rows[0][4].ToString();
            tbArea.Text = dt.Rows[0][5].ToString();
            tbPhoneNum.Text = dt.Rows[0][6].ToString();
            tbResidenRegisNum.Text = dt.Rows[0][7].ToString();

            prevS = int.Parse(dt.Rows[0][8].ToString());
            if (prevS == 0)
                lbSuccess.Text = "미접종 상태";
            else
                lbSuccess.Text = "접종완료";

            sqldb.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string s1 = "(";
            string s2 = "(";

            //현재 dialog에서 선택한 년, 월, 일을 숫자로 변환하여 a,b,c 변수에 저장
            int a = int.Parse(dtDate.Value.ToString("yyyy"));
            int b = int.Parse(dtDate.Value.ToString("MM"));
            int c = int.Parse(dtDate.Value.ToString("dd"));

            //오늘 날짜 이전의 날짜를 선택한 경우 messagebox로 알려줌
            if ((a<year) || (a<=year)&&(b<month) || (a <= year) && (b <= month)&&(c<day))
                if (MessageBox.Show("날짜를 확인해주세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                    return;


            // textbox에 모든 값이 입력된 경우 sql문을 위한 문자열 저장
            if (tbId.Text != "" && tbPw.Text != "" && cbVaccine.SelectedItem.ToString() != "" && tbArea.Text != "" && tbPhoneNum.Text != "" && tbResidenRegisNum.Text != "")
            {
                s1 += "name, pw, hname, vaccine, date, area, phone, resident_regis_num)";
                s2 += $"N'{tbId.Text}',N'{tbPw.Text}',N'{Chname}',N'{cbVaccine.SelectedItem.ToString()}',N'{dtDate.Value.ToString("yyyy-MM-dd")}',N'{tbArea.Text}',N'{tbPhoneNum.Text}',N'{tbResidenRegisNum.Text}')";
            }
            else // textbox에 빈칸이 하나라도 있으면 messagebox로 경고
            {
                if (MessageBox.Show("정보를 정확히 입력해주세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                    return;
            }

            // db실행
            SqlDB sqldb = new SqlDB(sqlPath);
            string sql = $"insert into patient {s1} values {s2}";

            // 저장 여부 한번 더 확인
            if (MessageBox.Show("저장하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // 중복된 주민번호의 경우 예약 불가능
                string rNum = sqldb.GetString($"select resident_regis_num from patient where resident_regis_num = N'{tbResidenRegisNum.Text}'");
                if(rNum == tbResidenRegisNum.Text)
                {
                    if (MessageBox.Show("주민번호를 확인해주세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                        return;
                }

                // temp : vcount의 값이 아예 없는 경우 '-'값이 들어옴
                string temp = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{Chname}' and vname = N'{cbVaccine.Text}' and vdate = '{dtDate.Value.ToString("yyyy-MM-dd")}'");
                if(temp == "-")
                {
                    if (MessageBox.Show("해당 백신은 예약이 불가능합니다.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                        return;
                }

                // temp를 정수형으로 변환 ==>> vcount가 0보다 작으면 백신예약 불가능
                int vcount = int.Parse(temp);
                if (vcount <= 0)
                {
                    if (MessageBox.Show("해당 백신은 예약이 불가능합니다.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                        return;
                }

                // vcount를 다시 조작 후, db 업데이트
                vcount -= 1;
                sqldb.Run($"update vaccineTable set vcount = {vcount} where hosptialName = N'{Chname}' and vname = N'{cbVaccine.Text}' and vdate = '{dtDate.Value.ToString("yyyy-MM-dd")}'");
                sqldb.Run(sql);
                sqldb.Close();
                this.DialogResult = DialogResult.OK;
            }
            else return;
        }

        private void btnRevice_Click(object sender, EventArgs e)
        {
            string s1 = "";
            //string s2 = "(";

            //현재 dialog에서 선택한 년, 월, 일을 숫자로 변환하여 a,b,c 변수에 저장
            int a = int.Parse(dtDate.Value.ToString("yyyy"));
            int b = int.Parse(dtDate.Value.ToString("MM"));
            int c = int.Parse(dtDate.Value.ToString("dd"));

            //오늘 날짜 이전의 날짜를 선택한 경우 messagebox로 알려줌
            if ((a < year) || (a <= year) && (b < month) || (a <= year) && (b <= month) && (c < day))
                if (MessageBox.Show("날짜를 확인해주세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                    return;

            // textbox에 모든 값이 입력된 경우 sql문을 위한 문자열 저장
            if (tbId.Text != "" && tbPw.Text != "" && cbVaccine.SelectedItem.ToString() != "" && tbArea.Text != "" && tbPhoneNum.Text != "" && tbResidenRegisNum.Text != "")
            {
                s1 += $"hname=N'{lbHospital.Text}', vaccine=N'{cbVaccine.SelectedItem.ToString()}', date=N'{dtDate.Value.ToString("yyyy-MM-dd")}', area=N'{tbArea.Text}', phone=N'{tbPhoneNum.Text}', resident_regis_num=N'{tbResidenRegisNum.Text}' ";
                //s2 += $"N'{tbId.Text}',N'{tbPw.Text}',N'{Chname}',N'{cbVaccine.SelectedItem.ToString()}',N'{dtDate.Value.ToString("yyyy-MM-dd")}',N'{tbArea.Text}',N'{tbPhoneNum.Text}',N'{tbResidenRegisNum.Text}')";
            }
            else // textbox에 빈칸이 하나라도 있으면 messagebox로 경고
            {
                if (MessageBox.Show("정보를 정확히 입력해주세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                    return;
            }

            if (tbId.Text != rName || tbPw.Text != rPW)
            {
                if (MessageBox.Show("이름과 password를 확인하세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                    return;
            }

            // db실행
            SqlDB sqldb = new SqlDB(sqlPath);
            string sql = $"update patient set {s1} where name = N'{tbId.Text}' and pw = N'{tbPw.Text}' and resident_regis_num = N'{tbResidenRegisNum.Text}'";



            if (prevS != 0)
            {
                if (MessageBox.Show("접종 완료자입니다.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                    return;
                }
            }

            // 저장 여부 한번 더 확인
            if (MessageBox.Show("저장하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // temp : vcount의 값이 아예 없는 경우 '-'값이 들어옴
                string temp = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{lbHospital.Text}' and vname = N'{cbVaccine.Text}' and vdate = '{dtDate.Value.ToString("yyyy-MM-dd")}'");
                if (temp == "-")
                {
                    if (MessageBox.Show("해당 백신은 예약이 불가능합니다.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                        return;
                }

                // temp를 정수형으로 변환 ==>> vcount가 0보다 작으면 백신예약 불가능
                int vcount = int.Parse(temp);
                if (vcount <= 0)
                {
                    if (MessageBox.Show("해당 백신은 예약이 불가능합니다.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                        return;
                }

                // vcount를 다시 조작 후, db 업데이트
                vcount -= 1;
                sqldb.Run($"update vaccineTable set vcount = {vcount} where hosptialName = N'{lbHospital.Text}' and vname = N'{cbVaccine.Text}' and vdate = '{dtDate.Value.ToString("yyyy-MM-dd")}'");
                sqldb.Run(sql);

                int prevCount = int.Parse(sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{prevhname}' and vname = N'{prevVaccine}' and vdate = '{prevDate}'"));
                prevCount += 1;
                sqldb.Run($"update vaccineTable set vcount = {prevCount} where hosptialName = N'{prevhname}' and vname = N'{prevVaccine}' and vdate = '{prevDate}'");

                sqldb.Close();
                this.DialogResult = DialogResult.OK;
            }
            else return;
        }
    }
}

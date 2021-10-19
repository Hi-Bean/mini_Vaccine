using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLibrary;

namespace miniProject_Vaccine
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            year = int.Parse(dateTimePicker1.Value.ToString("yyyy"));
            month = int.Parse(dateTimePicker1.Value.ToString("MM"));
            day = int.Parse(dateTimePicker1.Value.ToString("dd"));
        }

        //SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");
        //string CurrentTable = "";
        string CurrentHospitalName = "";
        int year, month, day;           // 오늘 날짜
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (cbHospitalName.SelectedItem == null)
                if (MessageBox.Show("병원을 선택해주세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                    return;

            SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");
            string tname = "hospitalINFO"; string hname = CurrentHospitalName;
            string sql1 = $"select hphone from {tname} where hname = N'{hname}'";

            lbHospiName.Text = hname;
            lbHospPhone.Text = sqldb.GetString(sql1);

            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            sql1 = $"select vname, vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}'";
            //textBox2.Text += sqldb.GetString(sql1);

            //DataTable d = (DataTable)sqldb.Run(sql1);

            lbVaccineA.Text = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}' and vname = 'AZ'");
            lbVaccineH.Text = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}' and vname = N'화이자'");
            lbVaccineM.Text = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}' and vname = N'모더나'");
            lbVaccineY.Text = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}' and vname = N'얀센'");

            sqldb.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");
            string url = "http://localhost:8888";
            this.webBrowser1.Navigate(url);

            DataTable d = (DataTable)sqldb.Run($"select hname from hospitalINFO");
            for(int i=0; i<d.Rows.Count; i++)
                cbHospitalName.Items.Add(d.Rows[i][0]);
            sqldb.Close();
        }

        private void cbHospitalName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentHospitalName = cbHospitalName.SelectedItem.ToString();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if(cbHospitalName.SelectedItem == null)
                if (MessageBox.Show("병원을 선택해주세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                    return;

            //string sID, sArea, sPhone, sRegis;
            frmAppointment dlg = new frmAppointment(CurrentHospitalName, year, month,day);

            string sID = "";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sID = dlg.tbId.Text;
                //string sPW = dlg.tbPw.Text;
                //string sArea = dlg.tbArea.Text;
                //string sPhone = dlg.tbPhoneNum.Text;
                //string sRegis = dlg.tbResidenRegisNum.Text;
            }
        }

        private void btnChatt_Click(object sender, EventArgs e)
        {

        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            frmLogin dlgLogin = new frmLogin();
            if (dlgLogin.ShowDialog() == DialogResult.OK)
            {
                string name = dlgLogin.tbName.Text;
                string pw = dlgLogin.tbPW.Text;
                SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");
                DataTable dt = (DataTable)sqldb.Run($"select hname, date, vaccine from patient where name = N'{name}' and pw = N'{pw}'");
                tbNote.Text = $"예약정보는 다음과 같습니다.\r\n\r\n[예약자]\t{name} 님\r\n[병원]\t{dt.Rows[0][0]}\r\n[접종일]\t{dt.Rows[0][1]}\r\n[백신]\t{dt.Rows[0][2]}\r\n";
            }
            else
                dlgLogin.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string name, pw;
            frmLogin dlgLogin = new frmLogin();
            if (dlgLogin.ShowDialog() == DialogResult.OK)
            {
                name = dlgLogin.tbName.Text;
                pw = dlgLogin.tbPW.Text;
            }
            else
                return;

            frmAppointment dlg = new frmAppointment(name, pw, year, month, day);
            if(dlg.ShowDialog() == DialogResult.OK)
            { }

        }
    }
}

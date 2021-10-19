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
        }

        //SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");
        string CurrentTable = "";
        string CurrentHospitalName = "";
        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");
            string tname = "hospitalINFO"; string hname = CurrentHospitalName;
            string sql1 = $"select hphone from {tname} where hname = N'{hname}'";

            lbHospiName.Text = hname;
            lbHospPhone.Text = sqldb.GetString(sql1);

            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            sql1 = $"select vname, vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}'";
            textBox2.Text += sqldb.GetString(sql1);

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
            //string sID, sArea, sPhone, sRegis;
            frmAppointment dlg = new frmAppointment();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string sID = dlg.tbId.Text;
                string sPW = dlg.tbPw.Text;
                string sArea = dlg.tbArea.Text;
                string sPhone = dlg.tbPhoneNum.Text;
                string sRegis = dlg.tbResidenRegisNum.Text;
            }
        }
    }
}

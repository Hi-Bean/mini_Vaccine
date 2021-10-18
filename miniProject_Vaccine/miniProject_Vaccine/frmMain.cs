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

        SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");
        string CurrentTable = "";
        private void btnTest_Click(object sender, EventArgs e)
        {
            string tname = "hospitalINFO"; string hname = "우리내과의원";
            string sql1 = $"select hphone from {tname} where hname = N'{hname}'";

            lbHospiName.Text = hname;
            lbHospPhone.Text = sqldb.GetString(sql1);

            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            sql1 = $"select vname, vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}'";
            textBox2.Text += sqldb.GetString(sql1);

            DataTable d = (DataTable)sqldb.Run(sql1);

            lbVaccineA.Text = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}' and vname = 'AZ'");
            lbVaccineH.Text = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}' and vname = N'화이자'");
            lbVaccineM.Text = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}' and vname = N'모더나'");
            lbVaccineY.Text = sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{hname}' and vdate='{date}' and vname = N'얀센'");
        }
    }
}

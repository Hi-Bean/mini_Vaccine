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
        public frmAppointment()
        {
            InitializeComponent();
            cbVaccine.Items.Add("화이자");
            cbVaccine.Items.Add("모더나");
            cbVaccine.Items.Add("아스트라제네카");
            cbVaccine.Items.Add("얀센");
        }

        //SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\si129\source\repos\플젝 2\mini_Vaccine_DB-main (1)\mini_Vaccine_DB-main\myHospital_DB\myHospital.mdf;Integrated Security = True; Connect Timeout = 30");
        string CurrentTable = "";
        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");

            string s1 = "(";
            string s2 = "(";

            if (tbId.Text != "")
            { s1 += "name"; s2 += $"N'{tbId.Text}'"; }
            if (tbId.Text != "")
            { s1 += ",pw"; s2 += $",N'{tbPw.Text}'"; }
            if (cbVaccine.Text != "")
            { s1 += ",vaccine"; s2 += $",N'{cbVaccine.Text}'"; }
            if (dtDate.Value.ToString() != "")
            { s1 += ",date"; s2 += $",N'{dtDate.Value.ToString("yyyy-MM-dd")}'"; }
            if (tbArea.Text != "")
            { s1 += ",area"; s2 += $",N'{tbArea.Text}'"; }
            if (tbPhoneNum.Text != "")
            { s1 += ",phone"; s2 += $",N'{tbPhoneNum.Text}'"; }
            if (tbResidenRegisNum.Text != "")
            { s1 += ",resident_regis_num"; s2 += $",N'{tbResidenRegisNum.Text}'"; }

            s1 += ")"; s2 += ")";

            string sql = $"insert into patient {s1} values {s2}";

            if (MessageBox.Show("저장하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqldb.Run(sql);
                int vcount = int.Parse(sqldb.GetString($"select vcount from vaccineTable where vname = N'{cbVaccine.Text}' and vdate = '{dtDate.Value.ToString("yyyy-MM-dd")}'"));
                vcount -= 1;
                sqldb.Run($"update vaccineTable set vcount = {vcount} where vname = N'{cbVaccine.Text}' and vdate = '{dtDate.Value.ToString("yyyy-MM-dd")}'");
                sqldb.Close();
                this.DialogResult = DialogResult.OK;
            }
            else return;

            
        }
    }
}

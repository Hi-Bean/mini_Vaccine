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
        string Chname = "";
        public frmAppointment(string hosName)
        {
            InitializeComponent();
            cbVaccine.Items.Add("화이자");
            cbVaccine.Items.Add("모더나");
            cbVaccine.Items.Add("AZ");
            cbVaccine.Items.Add("얀센");

            Chname = hosName;
            lbHospital.Text = Chname;
        }

        //SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\si129\source\repos\플젝 2\mini_Vaccine_DB-main (1)\mini_Vaccine_DB-main\myHospital_DB\myHospital.mdf;Integrated Security = True; Connect Timeout = 30");
        string CurrentTable = "";
        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlDB sqldb = new SqlDB(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30");

            string s1 = "(";
            string s2 = "(";

            if (tbId.Text != "" && tbPw.Text != "" && cbVaccine.SelectedItem.ToString() != "" && tbArea.Text != "" && tbPhoneNum.Text != "" && tbResidenRegisNum.Text != "")
            {
                s1 += "name, pw, vaccine, date, area, phone, resident_regis_num)";
                s2 += $"N'{tbId.Text}',N'{tbPw.Text}',N'{cbVaccine.SelectedItem.ToString()}',N'{dtDate.Value.ToString("yyyy-MM-dd")}',N'{tbArea.Text}',N'{tbPhoneNum.Text}',N'{tbResidenRegisNum.Text}')";
            }
            else
            {
                if (MessageBox.Show("정보를 정확히 입력해주세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                    return;
            }

            string sql = $"insert into patient {s1} values {s2}";

            if (MessageBox.Show("저장하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int vcount = int.Parse(sqldb.GetString($"select vcount from vaccineTable where hosptialName = N'{Chname}' and vname = N'{cbVaccine.Text}' and vdate = '{dtDate.Value.ToString("yyyy-MM-dd")}'"));
                if(vcount <= 0)
                {
                    if (MessageBox.Show("해당 백신은 예약이 불가능합니다.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                        return;
                }
                vcount -= 1;
                sqldb.Run($"update vaccineTable set vcount = {vcount} where hosptialName = N'{Chname}' and vname = N'{cbVaccine.Text}' and vdate = '{dtDate.Value.ToString("yyyy-MM-dd")}'");
                sqldb.Run(sql);
                sqldb.Close();
                this.DialogResult = DialogResult.OK;
            }
            else return;

            
        }
    }
}

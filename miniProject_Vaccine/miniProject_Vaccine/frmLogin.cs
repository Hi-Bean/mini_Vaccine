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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            //lbName.Text = na;
            InitializeComponent();
        }

        string sqlPath = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallo\Desktop\myHospital_DB\myHospital.mdf;Integrated Security=True;Connect Timeout=30";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDB sqldb = new SqlDB(sqlPath);
            
            if(tbName.Text == "" || tbPW.Text == "" || tbRegisterNum.Text == "")
            {
                if (MessageBox.Show("빈칸에 값을 입력하세요.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                    return;
            }
            else
            {
                string s = sqldb.GetString($"select name from patient where name = N'{tbName.Text}' and pw = N'{tbPW.Text}' and resident_regis_num = N'{tbRegisterNum.Text}'");
                if (s == tbName.Text)
                {
                    sqldb.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    if (MessageBox.Show("예약자의 정보가 올바르지 않습니다.\r\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                        return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

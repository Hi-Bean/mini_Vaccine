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
        public frmLogin(string na, string p)
        {
            label1.Text = na;
            label2.Text = p;
            InitializeComponent();
        }
    }
}

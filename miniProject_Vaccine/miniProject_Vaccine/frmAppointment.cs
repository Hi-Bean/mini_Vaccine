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
    }
}

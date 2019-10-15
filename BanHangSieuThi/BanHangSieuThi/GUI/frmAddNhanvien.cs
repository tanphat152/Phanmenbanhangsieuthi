using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi.GUI
{
    public partial class frmAddnhanvien : Form
    {
        public frmAddnhanvien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) checkBox2.Checked = false;
            else if (checkBox2.Checked == true) checkBox1.Checked = false;
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

       
  
        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            frmKhachhang a = new frmKhachhang();
            this.Hide();
            a.ShowDialog();
            this.Show();

        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {

        }
    }
}

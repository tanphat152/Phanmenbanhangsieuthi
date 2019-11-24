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

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            formnhanvien a = new formnhanvien();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            frombanhang a = new frombanhang();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            formnhap_hang nhaphang = new formnhap_hang();
            nhaphang.ShowDialog();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            thongke fr = new thongke();
            fr.Show();
        }
    }
}

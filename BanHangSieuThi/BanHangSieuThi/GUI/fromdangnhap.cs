using BanHangSieuThi.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi.GUI
{
    public partial class fromdangnhap : Form
    {
        internal static int checkConnectionString;
        public fromdangnhap()
        {
            InitializeComponent();
            Thread threadCheckConnect = new Thread(check);
            threadCheckConnect.Start();
        }
        public void check()
        {
            ConnectString check = new ConnectString();
            checkConnectionString = check.checkCnn();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmMain fr = new frmMain();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }
    }
}

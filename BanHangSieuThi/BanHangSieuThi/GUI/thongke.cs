using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BanHangSieuThi.DataAccess;
namespace BanHangSieuThi.GUI
{
    public partial class thongke : Form
    {
        SqlConnection conn = new SqlConnection();
        ConnectString cnn = new ConnectString();
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        string query = "";
        DataTable dt = new DataTable();
        public thongke()
        {
            InitializeComponent();
        }

        private void thongke_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                try
                {
                    query = "ThongKe_SP";
                    cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);
                    dtgv_thongke.DataSource = dt;
                }
                catch
                    { }
            }

        }
    }
}

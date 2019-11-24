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
        void load()
        {
            txt_MaSP.Text = dtgv_thongke.Rows[0].Cells["Mã sản phẩm"].Value.ToString();
            txt_SP.Text = dtgv_thongke.Rows[0].Cells["Tên sản phẩm"].Value.ToString();
            txt_SoLuong.Text = dtgv_thongke.Rows[0].Cells["Số lượng"].Value.ToString();
            txt_NSX.Text = dtgv_thongke.Rows[0].Cells["NSX"].Value.ToString();

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

        private void dtgv_thongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dtgv_thongke.CurrentRow.Index;
            txt_MaSP.Text = dtgv_thongke.Rows[index].Cells["Mã sản phẩm"].Value.ToString();
            txt_SP.Text= dtgv_thongke.Rows[index].Cells["Tên sản phẩm"].Value.ToString();
            txt_SoLuong.Text = dtgv_thongke.Rows[index].Cells["Số lượng"].Value.ToString();
            txt_NSX.Text = dtgv_thongke.Rows[index].Cells["NSX"].Value.ToString();

        }
    }
}

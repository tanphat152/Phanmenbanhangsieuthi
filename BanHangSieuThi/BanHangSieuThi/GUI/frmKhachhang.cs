using BanHangSieuThi.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi.GUI
{
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
            showdata();
        }
        public static string IDcart;
        public static int them = 0;
        public static int sua = 0;
        public static int xoa = 0;
        private void btnNhanvien_Click(object sender, EventArgs e)
        {

        }
        public void showdata()
        {
            string query = "SELECT MaKH AS 'Mã',TenKH 'Họ tên',GT AS 'Giới tính',DiaChi as 'Địa chỉ',SDT AS 'SĐT',LoaiKH AS 'Xếp loại', GhiChu AS 'Ghi chú' FROM dbo.tblKhachHang";
            DataSet data = new DataSet();
            // create datatable connect database Users
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(fromdangnhap.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            showSp.DataSource = data.Tables[0];
        }
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

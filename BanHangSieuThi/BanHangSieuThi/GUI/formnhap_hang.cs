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
    public partial class formnhap_hang : Form
    {
        
        public formnhap_hang()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand cmd;
        ConnectString connectStr = new ConnectString();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT MaSP,TenSP,TenLH,SoLuong,LoiNhuan,GiaNhap,GiaBan,MoTa,NSX FROM dbo.tblSanPham,dbo.tblLoaiHang WHERE tblLoaiHang.MaLH=tblSanPham.MaLH";
            adap.SelectCommand = cmd;
            table.Clear();
            adap.Fill(table);
            gunaDataGridView1.DataSource = table;

        }
        private void formnhap_hang_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectStr.getConnectionString(1)))
            {
                connection.Open();
                LoadData();
                connection.Close();
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            using(connection = new SqlConnection(connectStr.getConnectionString(1)))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO dbo.tblSanPham VALUES  ( '"+guTbMaSP.Text+"' , N'"+guTbTenSP.Text+ "' , 'LH5' , "+guTbSLSP.Text+" , '"+guTbLoiNhuanSP.Text+"' , '"+guTbGiaNhapSP.Text+"' , '"+guTbGiaBanSP.Text+"' , N'"+guTbMoTa.Text+"' , N'"+guTbNXS.Text+ "' , N'' , N'LaptopVip' )";
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("thêm thành công");
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công");
                }
                LoadData();
                connection.Close();
            }
        }
    }
}

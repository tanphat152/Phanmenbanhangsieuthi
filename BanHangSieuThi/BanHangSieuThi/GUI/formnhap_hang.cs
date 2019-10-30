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
            guTbMaSP.Enabled = false;
            guTbTenSP.Enabled = false;
            guTbGiaNhapSP.Enabled = false;
            guTbGiaBanSP.Enabled = false;
            guTbLoaiSP.Enabled = false;
            guTbSLSP.Enabled = false;
            guTbLoiNhuanSP.Enabled = false;
            guTbMoTa.Enabled = false;
            guTbNXS.Enabled = false;
            gunaBtSua.Enabled = false;
            using (connection = new SqlConnection(connectStr.getConnectionString(fromdangnhap.checkConnectionString)))
            {
                connection.Open();
                LoadData();
                connection.Close();
            }

        }
        int dem = 0;
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            dem = 1;
            guTbMaSP.Enabled = true;
            guTbTenSP.Enabled = true;
            guTbGiaNhapSP.Enabled = true;
            guTbGiaBanSP.Enabled = true;
            guTbLoaiSP.Enabled = true;
            guTbSLSP.Enabled = true;
            guTbLoiNhuanSP.Enabled = true;
            guTbMoTa.Enabled = true;
            guTbNXS.Enabled = true;
            
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gunaDataGridView1.CurrentRow.Index;
            guTbMaSP.Text = gunaDataGridView1.Rows[i].Cells[0].Value.ToString();
            guTbTenSP.Text = gunaDataGridView1.Rows[i].Cells[1].Value.ToString();
            guTbLoaiSP.Text = gunaDataGridView1.Rows[i].Cells[2].Value.ToString();
            guTbSLSP.Text = gunaDataGridView1.Rows[i].Cells[3].Value.ToString();
            guTbGiaNhapSP.Text = gunaDataGridView1.Rows[i].Cells[4].Value.ToString();
            guTbGiaBanSP.Text = gunaDataGridView1.Rows[i].Cells[5].Value.ToString();
            guTbLoiNhuanSP.Text = gunaDataGridView1.Rows[i].Cells[6].Value.ToString();
            guTbMoTa.Text = gunaDataGridView1.Rows[i].Cells[7].Value.ToString();
            guTbNXS.Text = gunaDataGridView1.Rows[i].Cells[8].Value.ToString();
            gunaBtSua.Enabled = true;
        }
        string masp = "";
        private void gunaBtSua_Click(object sender, EventArgs e)
        {
            dem = 2;
            guTbMaSP.Enabled = true;
            guTbTenSP.Enabled = true;
            guTbGiaNhapSP.Enabled = true;
            guTbGiaBanSP.Enabled = true;
            guTbLoaiSP.Enabled = true;
            guTbSLSP.Enabled = true;
            guTbLoiNhuanSP.Enabled = true;
            guTbMoTa.Enabled = true;
            guTbNXS.Enabled = true;
            masp = guTbMaSP.Text;
        }

        private void gunaBtXoa_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectStr.getConnectionString(fromdangnhap.checkConnectionString)))
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "delete dbo.tblSanPham where MaSP='" + guTbMaSP.Text + "'"; 
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
                LoadData();
                connection.Close();
            }
        }

        private void gunaBtLuu_Click(object sender, EventArgs e)
        {
            if (dem == 1)
            {
                using (connection = new SqlConnection(connectStr.getConnectionString(fromdangnhap.checkConnectionString)))
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO dbo.tblSanPham VALUES  ( '" + guTbMaSP.Text + "' , N'" + guTbTenSP.Text + "' , 'LH5' , '" + guTbSLSP.Text + "' , '" + guTbLoiNhuanSP.Text + "' , '" + guTbGiaNhapSP.Text + "' , '" + guTbGiaBanSP.Text + "' , N'" + guTbMoTa.Text + "' , N'" + guTbNXS.Text + "' , N'' , N'LaptopVip' )";
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
            if (dem == 2)
            {
  
                using (connection = new SqlConnection(connectStr.getConnectionString(fromdangnhap.checkConnectionString)))
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE dbo.tblSanPham SET  MaSP='" + guTbMaSP.Text + "' ,TenSP=N'" + guTbTenSP.Text + "' , MaLH='LH5' , SoLuong='" + guTbSLSP.Text + "' , LoiNhuan='" + guTbLoiNhuanSP.Text + "' , GiaNhap='" + guTbGiaNhapSP.Text + "' , GiaBan='" + guTbGiaBanSP.Text + "' ,MoTa= N'" + guTbMoTa.Text + "' , NSX=N'" + guTbNXS.Text + "' ,HinhAnh=N'' , NhaCC=N'LaptopVip' WHERE MaSP='" + masp + "'";
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công");
       
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công");
                        
                    }
                    LoadData();
                    connection.Close();
                    gunaBtSua.Enabled = false;
                }
            }
            guTbMaSP.Enabled = false;
            guTbTenSP.Enabled = false;
            guTbGiaNhapSP.Enabled = false;
            guTbGiaBanSP.Enabled = false;
            guTbLoaiSP.Enabled = false;
            guTbSLSP.Enabled = false;
            guTbLoiNhuanSP.Enabled = false;
            guTbMoTa.Enabled = false;
            guTbNXS.Enabled = false;
        }

        private void gunaBtHuy_Click(object sender, EventArgs e)
        {
            guTbMaSP.Enabled = false;
            guTbTenSP.Enabled = false;
            guTbGiaNhapSP.Enabled = false;
            guTbGiaBanSP.Enabled = false;
            guTbLoaiSP.Enabled = false;
            guTbSLSP.Enabled = false;
            guTbLoiNhuanSP.Enabled = false;
            guTbMoTa.Enabled = false;
            guTbNXS.Text = "";
            guTbMaSP.Text = "";
            guTbTenSP.Text = "";
            guTbGiaNhapSP.Text = "";
            guTbGiaBanSP.Text = "";
            guTbLoaiSP.Text = "";
            guTbSLSP.Text = "";
            guTbLoiNhuanSP.Text = "";
            guTbMoTa.Text = "";
            guTbNXS.Text = "";
        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gunaDataGridView1.CurrentRow.Index;
            guTbMaSP.Text = gunaDataGridView1.Rows[i].Cells[0].Value.ToString();
            guTbTenSP.Text = gunaDataGridView1.Rows[i].Cells[1].Value.ToString();
            guTbLoaiSP.Text = gunaDataGridView1.Rows[i].Cells[2].Value.ToString();
            guTbSLSP.Text = gunaDataGridView1.Rows[i].Cells[3].Value.ToString();
            guTbGiaNhapSP.Text = gunaDataGridView1.Rows[i].Cells[4].Value.ToString();
            guTbGiaBanSP.Text = gunaDataGridView1.Rows[i].Cells[5].Value.ToString();
            guTbLoiNhuanSP.Text = gunaDataGridView1.Rows[i].Cells[6].Value.ToString();
            guTbMoTa.Text = gunaDataGridView1.Rows[i].Cells[7].Value.ToString();
            guTbNXS.Text = gunaDataGridView1.Rows[i].Cells[8].Value.ToString();
            gunaBtSua.Enabled = true;
        }
    }
}

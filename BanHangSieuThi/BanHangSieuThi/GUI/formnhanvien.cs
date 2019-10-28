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
    public partial class formnhanvien : Form
    {
        public formnhanvien()
        {
            InitializeComponent();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            string hoten = gunaTxtTen.Text;
            string tendn = gunaTxtDiachi.Text;
            string diachi = gunaTxtDiachi.Text;
            string gioitinh;
            if(gunaCheckBoxNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            string sdt = gunaTxtSdt.Text;
            if(hoten =="" || tendn =="")
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin");
                return;
            }

        }
        SqlConnection connection;
        SqlCommand cmd;
        ConnectString connectStr = new ConnectString();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable table = new DataTable();
        public void LoadData()
        {
            cmd= connection.CreateCommand();
            cmd.CommandText = "SELECT TenNV as Hoten,TenDn as TenDangNhap ,DiaChi as Diachi,GT as GT,SDT as SDT FROM dbo.tblNhanVien";
            adap.SelectCommand = cmd;
            table.Clear();
            adap.Fill(table);
            gunaDataGridView1.DataSource = table;
        }

        private void formnhanvien_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectStr.getConnectionString(0)))
            {
                connection.Open();
                LoadData();
                connection.Close();
            }
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

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
            using (connection = new SqlConnection(connectStr.getConnectionString(fromdangnhap.checkConnectionString)))
            {
                connection.Open();
                LoadData();
                connection.Close();
            }
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSuanhanvien_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        public int insert()
        {
            string name = gunaTxtTen.Text;
            string sdt = gunaTxtSdt.Text;
            string Diachi = gunaTxtDiachi.Text;
            string gioitinh;
            if (gunaCheckBoxNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }
            string tendangnhap = gunaTxtTdn.Text;
            string query = " INSERT dbo.tblNhanVien( TenDn ,MatKhau ,TenNV ,GT ,DiaChi ,SDT) VALUES  (@tendangnhap ,  @matkhau , @name, @gt, @diachi, @sdt)";
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(fromdangnhap.checkConnectionString);
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    // insert value of Song in database
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
                    cmd.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = Diachi;
                    cmd.Parameters.Add("@tendangnhap", SqlDbType.NChar).Value = tendangnhap;
                    cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = "123456";

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                return 0;
            }
        }
        private void gunabtnSave_Click(object sender, EventArgs e)
        {
            int check = insert();
            if (check == 1)
            {
                MessageBox.Show("Thêm thành công!");
                connection.Open();
                LoadData();
                connection.Close();
            }
            else
            {

            }

        }
    }
}

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
            string gt;
            if (gunaCheckBoxNam.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            string sdt = gunaTxtSdt.Text;
            string matkhau = gunaTxtMatkhau.Text;
            if (hoten == "" || tendn == "")
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin");
                return;
            }
            else
            {
                int check = insert_data(hoten, tendn, diachi, gt, sdt, matkhau);
                if (check == 1)
                {
                    DialogResult res = MessageBox.Show("Thêm thành công, bạn có muốn tiếp tục?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        gunaTxtTdn.Text = "";
                        gunaTxtTen.Text = "";
                        gunaTxtDiachi.Text = "";
                        gunaTxtMatkhau.Text = "";
                    }
                    if (res == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }

        }
        SqlConnection connection;
        SqlCommand cmd;
        ConnectString connectStr = new ConnectString();
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable table = new DataTable();


        public void LoadData()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT TenNV as Hoten,TenDn as TenDangNhap ,DiaChi as Diachi,GT as GT,SDT as SDT, MATKHAU as MatKhau FROM dbo.tblNhanVien";
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
        public int insert_data(string hoten, string tendn, string diachi, string gt, string sdt, string matkhau)
        {
            string query = "INSERT INTO dbo.tblNhanVien (TenDn, MatKhau, TenNV, GT, DiaChi, SDT) VALUES (@tendn, @matkhau, @hoten, @gt , @diachi, @sdt)";
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(0);
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.Parameters.Add("@TenDn", SqlDbType.NVarChar).Value = tendn;
                    cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = matkhau;
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = hoten;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diachi;
                    cmd.Parameters.Add("@GT", SqlDbType.VarChar).Value = gt;
                    cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


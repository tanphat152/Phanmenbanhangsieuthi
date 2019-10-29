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

        private void btnaddNhanvien_Click(object sender, EventArgs e)
        {
            gunaTxtTen.Enabled = true;
            gunaTxtTdn.Enabled = true;
            gunaTxtDiachi.Enabled = true;
            gunaTxtSdt.Enabled = true;
            gunaCheckBoxNam.Enabled = true;
            gunaCheckBoxNu.Enabled = true;
            gunaTxtMatkhau.Enabled = true;
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
            else
            {

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
            gunaTxtTen.Enabled = false;
            gunaTxtTdn.Enabled = false;
            gunaTxtDiachi.Enabled = false;
            gunaTxtSdt.Enabled = false;
            gunaCheckBoxNam.Enabled = false;
            gunaCheckBoxNu.Enabled = false;
            gunaTxtMatkhau.Enabled = false;
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

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gunaDataGridView1.CurrentRow.Index;
            gunaTxtTen.Text = gunaDataGridView1.Rows[i].Cells[0].Value.ToString();
            gunaTxtTdn.Text = gunaDataGridView1.Rows[i].Cells[1].Value.ToString();
            gunaTxtDiachi.Text = gunaDataGridView1.Rows[i].Cells[2].Value.ToString();
            if (gunaDataGridView1.Rows[i].Cells[3].Value.ToString() == "Nam")
            {
                gunaCheckBoxNam.Checked = true;
            }
            else gunaCheckBoxNu.Checked = false;
            gunaTxtSdt.Text = gunaDataGridView1.Rows[i].Cells[4].Value.ToString();
            gunaTxtMatkhau.Text = gunaDataGridView1.Rows[i].Cells[5].Value.ToString();

        }
    }
}

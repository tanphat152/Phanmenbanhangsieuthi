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
            grop1.Enabled = false;
            showdata();
        }
        public static string ID;
        public static int them = 0;
        public static int sua = 0;
        public static int xoa = 0;

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

        private void showSp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posClicked;
            posClicked = showSp.SelectedRows[0].Index;
            DataGridViewRow temp = this.showSp.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            frmKhachhang.ID = Ma;
            show();
        }
        private DataTable connectionTable(string ma)
        {
            DataTable data = new DataTable();
            // create datatable connect database Users
            string query = " SELECT * FROM dbo.tblKhachHang WHERE MaKH='" + ma + "'";
            ConnectString cnn = new ConnectString();
            string con = cnn.getConnectionString(fromdangnhap.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }
        public void show()
        {

            DataTable data = connectionTable(frmKhachhang.ID);
            txt_ma.Text = data.Rows[0]["MaKH"].ToString();
            txt_ten.Text = data.Rows[0]["TenKH"].ToString();
            string gioitinh = data.Rows[0]["GT"].ToString().TrimEnd();
            if (gioitinh == "Nam")
            {
                check_nam.Checked = true;
                check_nu.Checked = false;
            }
            else
            {
                check_nam.Checked = false;
                check_nu.Checked = true;
            }
            txt_sdt.Text = data.Rows[0]["SDT"].ToString();
            txt_diachi.Text = data.Rows[0]["DiaChi"].ToString();
            txt_ghichu.Text = data.Rows[0]["GhiChu"].ToString();
            txt_type.Text = data.Rows[0]["LoaiKH"].ToString();


        }
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            grop1.Enabled = true;
            txt_ma.Enabled = true;
            txt_ma.Text = "";
            txt_type.Text = "";
            txt_ghichu.Text = "";
            txt_ten.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            frmKhachhang.them = 1;
            frmKhachhang.sua = 0;
            frmKhachhang.xoa = 0;
            them_btx.Enabled = true;
            sua_btx.Enabled = false;
            xoa_btx.Enabled = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (frmKhachhang.them == 1)
            {
                int check = insert();
                if (check == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    them_btx.Enabled = true;
                    sua_btx.Enabled = true;
                    xoa_btx.Enabled = true;
                    showdata();
                }
                else
                {

                }

            }
            
            if (frmKhachhang.sua == 1)
            {
                int check = upDate();
                if (check == 1)
                {
                    them_btx.Enabled = true;
                    sua_btx.Enabled = true;
                    xoa_btx.Enabled = true;
                    MessageBox.Show("Sửa thành công!");
                    showdata();
                }
                else
                {

                }

            }
            /*
            if (frmKhachhang.xoa == 1)
            {

                DialogResult res = MessageBox.Show("Bạn có thực sự muốn xóa khach hang có mã là" + frmKhachhang.ID.TrimEnd(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    delete(frmKhachhang.ID);
                    showdata();
                    them_btx.Enabled = true;
                    sua_btx.Enabled = true;
                    xoa_btx.Enabled = true;
                }
                if (res == DialogResult.No)
                {

                }

            }*/
        }
        public int insert()
        {
            string ma = txt_ma.Text;
            string name = txt_ten.Text;
            string sdt = txt_sdt.Text;
            string Diachi = txt_diachi.Text;
            string gioitinh;
            if (check_nam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            string type = txt_type.Text;
            string ghichu = txt_ghichu.Text;
            string query = " INSERT dbo.tblKhachHang( MaKH ,TenKH ,GT ,DiaChi ,SDT ,LoaiKH , GhiChu) VALUES  ( @ma , @name ,  @gt , @dc , @sdt , @type ,  @ghichu  )";
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
                    cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
                    cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
                    cmd.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
                    cmd.Parameters.Add("@dc", SqlDbType.NVarChar).Value = Diachi;
                    cmd.Parameters.Add("@ghichu", SqlDbType.NText).Value = ghichu;

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

        private void xoa_btx_Click(object sender, EventArgs e)
        {
            grop1.Enabled = false;
            them_btx.Enabled = false;
            sua_btx.Enabled = false;
            xoa_btx.Enabled = true;
            frmKhachhang.them = 0;
            frmKhachhang.sua = 0;
            frmKhachhang.xoa = 1;
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn xóa khach hang có mã là" + frmKhachhang.ID.TrimEnd(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                delete(frmKhachhang.ID);
                showdata();
                them_btx.Enabled = true;
                sua_btx.Enabled = true;
                xoa_btx.Enabled = true;
                txt_ma.Text = "";
                txt_type.Text = "";
                txt_ghichu.Text = "";
                txt_ten.Text = "";
                txt_sdt.Text = "";
                txt_diachi.Text = "";
            }
            if (res == DialogResult.No)
            {

            }
        }

        private void sua_btx_Click(object sender, EventArgs e)
        {
            txt_ma.Enabled = false;
            grop1.Enabled = true;
            frmKhachhang.them = 0;
            frmKhachhang.sua = 1;
            frmKhachhang.xoa = 0;

            them_btx.Enabled = false;
            sua_btx.Enabled = true;
            xoa_btx.Enabled = false;
        }
        public int upDate()
        {
            string ma = txt_ma.Text;
            string name = txt_ten.Text;
            string sdt = txt_sdt.Text;
            string Diachi = txt_diachi.Text;
            string gioitinh;
            if (check_nam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            string type = txt_type.Text;
            string ghichu = txt_ghichu.Text;
            string query = "UPDATE dbo.tblKhachHang SET TenKH=@name,GT=@gt,DiaChi=@dc,SDT=@sdt,LoaiKH=@type,GhiChu=@ghichu WHERE MaKH=@ma";
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
                    cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
                    cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = sdt;
                    cmd.Parameters.Add("@gt", SqlDbType.NVarChar).Value = gioitinh;
                    cmd.Parameters.Add("@dc", SqlDbType.NVarChar).Value = Diachi;
                    cmd.Parameters.Add("@ghichu", SqlDbType.NText).Value = ghichu;

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
        public void delete(string key)
        {
            string query1 = "DELETE	FROM dbo.tblKhachHang WHERE MaKH=  @ID";
            ConnectString b = new ConnectString();
            string con = b.getConnectionString(fromdangnhap.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query1;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = key;
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            grop1.Enabled = false;
            frmKhachhang.them = 0;
            frmKhachhang.sua = 0;
            frmKhachhang.xoa = 0;
            them_btx.Enabled = true;
            sua_btx.Enabled = true;
            xoa_btx.Enabled = true;
        }

        private void txt_seasch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT MaKH AS 'Mã',TenKH 'Họ tên',GT AS 'Giới tính',DiaChi as 'Địa chỉ',SDT AS 'SĐT',LoaiKH AS 'Xếp loại', GhiChu AS 'Ghi chú' FROM dbo.tblKhachHang" +
               " where dbo.tblKhachHang.TenKH like N'%" + txt_seasch.Text + "%'" + " OR DiaChi  LIKE N'%" + txt_seasch.Text + "%'" + " OR LoaiKH LIKE N'%" + txt_seasch.Text + "%'" + " OR GhiChu LIKE N'%" + txt_seasch.Text + "%'" +  " OR MaKH LIKE '%" + txt_seasch.Text + "%'";


            showSp.Columns.Clear();
            ConnectString b = new ConnectString();
            string con = b.getConnectionString(fromdangnhap.checkConnectionString);
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                DataSet data = new DataSet();
                SqlDataAdapter adap = new SqlDataAdapter(query, conn);
                adap.Fill(data);
                showSp.DataSource = data.Tables[0];
                conn.Close();
            }
        }
    }
}

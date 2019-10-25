using BanHangSieuThi.DataAccess;
using Guna.UI.WinForms;
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
    public partial class frombanhang : Form
    {
        public frombanhang()
        {
            InitializeComponent();
            addCheckBox();
            showDataView();
            showDataItem();
        }

        private void btn_nextNTT_Click(object sender, EventArgs e)
        {
            QuyTrinhBanHang.SelectedTab = tab2;
        }

        private void btn_NBH_Click(object sender, EventArgs e)
        {
            QuyTrinhBanHang.SelectedTab = tab3;
        }

        private void HoanThanh_Click(object sender, EventArgs e)
        {
            QuyTrinhBanHang.SelectedTab = tab1;
        }

        private void loadData(string query, GunaDataGridView dataView)
        {
            DataSet data = new DataSet();
            ConnectString b = new ConnectString();
            string con = b.getConnectionString(fromdangnhap.checkConnectionString);
            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, con);
                apter.Fill(data);
                connect.Close();
            }
            dataView.DataSource = data.Tables[0];
        }
        //show data for view type and ncc
        private void showDataView()
        {
            string queryType = "SELECT TenLH FROM tblLoaiHang";
            string queryNCC = "SELECT TenNCC FROM tblNhaCungCap";
            loadData(queryType, showType);
            loadData(queryNCC, showNCC);
        }
        private void addCheckBox()
        {
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "CheckBox";
            showType.Columns.Add(dgvCmb);
            DataGridViewCheckBoxColumn dgvCmb1 = new DataGridViewCheckBoxColumn();
            dgvCmb1.ValueType = typeof(bool);
            dgvCmb1.Name = "Chk";
            dgvCmb1.HeaderText = "CheckBox";
            showNCC.Columns.Add(dgvCmb1);
        }
        private void showDataItem()
        {
            string query = "SELECT TenSP,MaLH,SoLuong,GiaBan,MoTa,NSX FROM tblSanPham";
            loadData(query, showSp);
            string querySelected = "SELECT TenSP FROM tblSanPham where NSX like 'Dell'";
            loadData(querySelected, showItemSelected);
        }

    


    }
}

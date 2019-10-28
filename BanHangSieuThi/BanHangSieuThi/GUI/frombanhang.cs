using BanHangSieuThi.DataAccess;
using BanHangSieuThi.Object;
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
        Cart cart = null;
        string idItemSelected = null;
        public frombanhang()
        {
            InitializeComponent();
            QuyTrinhBanHang.SizeMode = TabSizeMode.Fixed;
            QuyTrinhBanHang.Appearance = TabAppearance.FlatButtons;
            QuyTrinhBanHang.ItemSize = new Size(0, 1);
            addCheckBox();
            showDataView();
            showDataItem();
            hideButton();
            cart = new Cart();
        }
        private void hideButton()
        {
            btn_addToCart.Enabled = false;
            btn_removeItem.Enabled = false;
            btn_removeCart.Enabled = false;
            btn_nextNTT.Enabled = false;
            btn_NBH.Enabled = false;
            checkTrueNBH.Checked = true;
            checkFalseNBH.Checked = false;
        }
        private void btn_nextNTT_Click(object sender, EventArgs e)
        {
            QuyTrinhBanHang.SelectedTab = tab2;
            reloadDataGridViewShowCart(cart.Get(), showCartOIFE);
            txt_priceCart.Text = cart.GetPriceOfCart().ToString();
            btn_NBH.Enabled = true;
        }
        

        private void btn_NBH_Click(object sender, EventArgs e)
        {
            QuyTrinhBanHang.SelectedTab = tab3;
        }

        private void HoanThanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã mua thành công");
            this.Close();

        }
        private void btn_BackChooseItem_Click(object sender, EventArgs e)
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
        private DataTable loadData(string query)
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
            return data.Tables[0];
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
            string query = "SELECT MaSP, TenSP,MaLH,SoLuong,GiaBan,MoTa,NSX FROM tblSanPham";
            loadData(query, showSp);
            //string querySelected = "SELECT TenSP FROM tblSanPham where NSX like 'Dell'";
            //loadData(querySelected, showCart);
        }


        #region action for datagridview
        private void showSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {

                btn_addToCart.Enabled = true;
                idItemSelected = showSp.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        #endregion

        #region action for tab chosse items
        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            if (cart!= null)
            {
                string query = "SELECT MaSP,TenSP, GiaBan FROM tblSanPham WHERE MaSP LIKE '" + idItemSelected + "'";
                DataTable data = loadData(query);
                Product product = new Product(data);
                cart.AddToList(product);
                reloadDataGridViewShowCart(cart.Get(), showCart);
                btn_removeCart.Enabled = true;
                btn_nextNTT.Enabled = true;
            }
            else
            {
                btn_removeCart.Enabled = false;
                btn_nextNTT.Enabled = false;
            }
        }
        private void reloadDataGridViewShowCart(DataTable data,GunaDataGridView dtgv)
        {
            dtgv.DataSource = data;
        }

        private void btn_removeCart_Click(object sender, EventArgs e)
        {
            cart.Clear();
            reloadDataGridViewShowCart(cart.Get(), showCart);
            btn_removeCart.Enabled = false;
        }

        #endregion

        #region action for tab choose customer

        #endregion

        #region action for tab choose customer

      
        private void checkTrueNBH_CheckedChanged(object sender, EventArgs e)
        {
            gunaGroupBox7.Enabled = true;
            checkFalseNBH.Checked = false;
        }
        #endregion

        private void checkFalseNBH_CheckedChanged(object sender, EventArgs e)
        {
            gunaGroupBox7.Enabled = false;
            checkTrueNBH.Checked = false;
        }

        private void checkTrueNBH_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}

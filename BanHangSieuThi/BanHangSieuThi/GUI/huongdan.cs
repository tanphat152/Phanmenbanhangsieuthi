using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi.GUI
{
    public partial class huongdan : Form
    {
        public huongdan()
        {
            InitializeComponent();
        }

        int dem = 0;
        string s1 = "", s2 = "";
        private void frHuongDanSuDung_Load(object sender, EventArgs e)
        {
            dem = 0;
            s1 = Application.StartupPath;
            s2 = s1.Substring(0, s1.Length - 9);
            gunaButton2.Enabled = true;
            gunaLabel2.Text = "Bước 1: Người dùng chạy ứng dụng quản lý trường THPT trên ứng dụng xuất hiện màn hình đăng nhập vào ứng dụng như hình sau.";
            gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\dangnhap.PNG");
            gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            gunaLabel3.Text = "Người dùng phải thông tin về tài khoản và mật khẩu tương ứng trên giao diện, và ấn đăng nhập.\n Nếu đúng tài khoản người dùng mới có thể vào được ứng dụng, nếu sai người dùng phải nhập lại. ";

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (dem > 11 || dem < 0) dem = 0;
            else if (dem >= 0 && dem <= 10)
                dem++;
            LayThongTin(dem);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (dem > 10 || dem < 0) dem = 0;
            else if (dem >= 0 && dem <= 10)
                dem++;
            LayThongTin(dem);
        }

        private void huongdan_Load(object sender, EventArgs e)
        {
            dem = 0;
            s1 = Application.StartupPath;
            s2 = s1.Substring(0, s1.Length - 9);
            gunaButton2.Enabled = true;
            gunaLabel2.Text = "Bước 1: Người dùng chạy ứng dụng quản lý siêu thị trên ứng dụng xuất hiện màn hình đăng nhập vào ứng dụng như hình sau.";
            gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\dangnhap.PNG");
            gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            gunaLabel3.Text = "Người dùng phải thông tin về tài khoản và mật khẩu tương ứng trên giao diện, và ấn đăng nhập.\n Nếu đúng tài khoản người dùng mới có thể vào được ứng dụng, nếu sai người dùng phải nhập lại. ";

        }

        private void LayThongTin(int x)
        {
            switch (x)
            {
                case 0:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 1: Người dùng chạy ứng dụng quản lý, trên ứng dụng xuất hiện màn hình đăng nhập vào ứng dụng như hình sau.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\dangnhap.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Người dùng phải thông tin về tài khoản và mật khẩu tương ứng trên giao diện, và ấn đăng nhập.\n Nếu đúng tài khoản người dùng mới có thể vào được ứng dụng, nếu sai người dùng phải nhập lại. ";
                    break;
                case 1:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 2: Khi đăng nhập thành công trên ứng dụng sẽ hiển thị giao diện màn hình chính như hình dưới.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\giaodienchinh.PNG");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Người dùng chọn một trong ba chức năng trên giao diên.";
                    break;
                case 2:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 3: Người dùng chọn vào biểu tượng khách hàng trên màn hình chính lập tức giao diện chính của chức năng quản lý khách hàng sẽ được hiển thị.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\qlkhachhang.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Tại đây người dùng xem được danh sách các khách hàng và thực hiện một số chức năng cơ bản như thêm, sửa, xóa và tìm kiếm .";
                    break;
                case 3:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 3.1: Chức năng thêm một khách hàng vào CSDL. Sau khi ấn thêm giao diện để điền thông tin khách hàng.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\themkhachhang.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Người dùng phải điền đầy đủ các thông tin trước khi thêm vào cơ sở dữ liệu để tránh thông báo lỗi không thêm được vào.";
                    break;
                case 4:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 3.2: Chọn một khách hàng trên danh sách đã được hiển thị sau đó mới được phép sửa thông tin và lưu lại.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\suakhachhang.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Giao diện sửa  cho phép người dùng có thể sửa các thông tin ";
                    break;
                case 5:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 3.3:Chức năng xóa một khách hàng";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\xoakhachhang.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Người dùng chọn một khách hàng sau đó ấn xóa khỏi dữ liệu.";
                    break;
                case 6:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 3.4: Chức năng tìm kiếm khách hàng.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\timkiemkhachhang.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Người dùng chọn tìm kiếm sẽ hiển thị thanh tìm kiếm và cho phép người dùng tìm kiếm theo họ và tên";
                    break;
                case 7:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 4: Người dùng chọn vào biểu tượng nhân viên trên màn hình chính lập tức giao diện chính của chức năng  sẽ được hiển thị.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\qlnhanvien.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Tại đây người dùng xem được danh sách các nhân viên và thực hiện một số chức năng cơ bản như thêm, sửa, xóa và tìm kiếm.";
                    break;
                case 8:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 4: Người dùng chọn vào biểu tượng bán hàng trên màn hình chính lập tức giao diện chính của chức năng sẽ được hiển thị.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\qlbanhang.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Tại đây người dùng xem được danh sách các hàng hóa và thực hiện một số chức năng cơ bản như thêm, sửa, xóa và tìm kiếm .";
                    break;
                case 9:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 4: Người dùng chọn vào biểu tượng nhập hàng trên màn hình chính lập tức giao diện chính của chức năng  sẽ được hiển thị.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\qlnhaphang.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Tại đây người dùng xem được danh sách các hàng hóa và thực hiện một số chức năng cơ bản như thêm, sửa, xóa và tìm kiếm.";
                    break;
                case 10:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 4: Người dùng chọn vào biểu tượng đăng xuất trên màn hình chính lập tức giao diện chính của chức năng sẽ được hiển thị.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\dangxuat.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Nếu đăng xuất ấn yes, không đăng xuất ấn no";
                    break;
                default:
                    gunaButton2.Enabled = true;
                    gunaLabel2.Text = "Bước 1: Người dùng chạy ứng dụng quản lý siêu thị trên ứng dụng xuất hiện màn hình đăng nhập vào ứng dụng như hình sau.";
                    gunaPictureBox1.Image = Image.FromFile(s2 + @"Image\dangnhap.png");
                    gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    gunaLabel3.Text = "Người dùng phải thông tin về tài khoản và mật khẩu tương ứng trên giao diện, và ấn đăng nhập.\n Nếu đúng tài khoản người dùng mới có thể vào được ứng dụng, nếu sai người dùng phải nhập lại. ";
                    break;

            }
        }
    }
}

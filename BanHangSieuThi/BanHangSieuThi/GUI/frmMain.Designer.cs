namespace BanHangSieuThi.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnNhaphang = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.btnBanhang = new Guna.UI.WinForms.GunaButton();
            this.btnNhanvien = new Guna.UI.WinForms.GunaButton();
            this.btnKhachhang = new Guna.UI.WinForms.GunaButton();
            this.btnNhaphang.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.Controls.Add(this.gunaButton2);
            this.btnNhaphang.Controls.Add(this.gunaButton1);
            this.btnNhaphang.Controls.Add(this.gunaLabel1);
            this.btnNhaphang.Controls.Add(this.gunaButton5);
            this.btnNhaphang.Controls.Add(this.gunaButton4);
            this.btnNhaphang.Controls.Add(this.btnBanhang);
            this.btnNhaphang.Controls.Add(this.btnNhanvien);
            this.btnNhaphang.Controls.Add(this.btnKhachhang);
            this.btnNhaphang.Location = new System.Drawing.Point(12, 12);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Size = new System.Drawing.Size(226, 538);
            this.btnNhaphang.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(140)))), ((int)(((byte)(181)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(94)))));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(220, 57);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Chức năng";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.AutoSize = true;
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(269, 4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(737, 546);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(94)))));
            this.gunaLabel2.Location = new System.Drawing.Point(6, 8);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(716, 66);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Hệ thống quản lý bán hàng siêu thị";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BanHangSieuThi.Properties.Resources.main1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton2.Location = new System.Drawing.Point(3, 332);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(220, 55);
            this.gunaButton2.TabIndex = 7;
            this.gunaButton2.Text = "Thống kê";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(0, 466);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(220, 59);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Text = "Đăng xuất";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton5
            // 
            this.gunaButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton5.Location = new System.Drawing.Point(3, 393);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Size = new System.Drawing.Size(220, 59);
            this.gunaButton5.TabIndex = 4;
            this.gunaButton5.Text = "Hướng dẫn";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton4
            // 
            this.gunaButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton4.Location = new System.Drawing.Point(3, 271);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(220, 55);
            this.gunaButton4.TabIndex = 3;
            this.gunaButton4.Text = "Nhập hàng";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBanhang
            // 
            this.btnBanhang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBanhang.AnimationHoverSpeed = 0.07F;
            this.btnBanhang.AnimationSpeed = 0.03F;
            this.btnBanhang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBanhang.BorderColor = System.Drawing.Color.Black;
            this.btnBanhang.FocusedColor = System.Drawing.Color.Empty;
            this.btnBanhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBanhang.ForeColor = System.Drawing.Color.White;
            this.btnBanhang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanhang.Image")));
            this.btnBanhang.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBanhang.Location = new System.Drawing.Point(3, 208);
            this.btnBanhang.Name = "btnBanhang";
            this.btnBanhang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBanhang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBanhang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBanhang.OnHoverImage = null;
            this.btnBanhang.OnPressedColor = System.Drawing.Color.Black;
            this.btnBanhang.Size = new System.Drawing.Size(220, 57);
            this.btnBanhang.TabIndex = 2;
            this.btnBanhang.Text = "Bán hàng";
            this.btnBanhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBanhang.Click += new System.EventHandler(this.btnBanhang_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNhanvien.AnimationHoverSpeed = 0.07F;
            this.btnNhanvien.AnimationSpeed = 0.03F;
            this.btnNhanvien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNhanvien.BorderColor = System.Drawing.Color.Black;
            this.btnNhanvien.FocusedColor = System.Drawing.Color.Empty;
            this.btnNhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnNhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.Image")));
            this.btnNhanvien.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNhanvien.Location = new System.Drawing.Point(3, 143);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNhanvien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNhanvien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNhanvien.OnHoverImage = null;
            this.btnNhanvien.OnPressedColor = System.Drawing.Color.Black;
            this.btnNhanvien.Size = new System.Drawing.Size(220, 59);
            this.btnNhanvien.TabIndex = 1;
            this.btnNhanvien.Text = "Quản lý nhân viên";
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKhachhang.AnimationHoverSpeed = 0.07F;
            this.btnKhachhang.AnimationSpeed = 0.03F;
            this.btnKhachhang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnKhachhang.BorderColor = System.Drawing.Color.Black;
            this.btnKhachhang.FocusedColor = System.Drawing.Color.Empty;
            this.btnKhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhachhang.ForeColor = System.Drawing.Color.White;
            this.btnKhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.Image")));
            this.btnKhachhang.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKhachhang.Location = new System.Drawing.Point(3, 79);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnKhachhang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKhachhang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKhachhang.OnHoverImage = null;
            this.btnKhachhang.OnPressedColor = System.Drawing.Color.Black;
            this.btnKhachhang.Size = new System.Drawing.Size(220, 58);
            this.btnKhachhang.TabIndex = 0;
            this.btnKhachhang.Text = "Quản lý khách hàng";
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(126)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1018, 562);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btnNhaphang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn hàng siêu thi";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.btnNhaphang.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel btnNhaphang;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton btnBanhang;
        private Guna.UI.WinForms.GunaButton btnNhanvien;
        private Guna.UI.WinForms.GunaButton btnKhachhang;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}
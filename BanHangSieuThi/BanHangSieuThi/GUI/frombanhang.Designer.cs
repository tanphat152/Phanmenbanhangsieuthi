namespace BanHangSieuThi.GUI
{
    partial class frombanhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frombanhang));
            this.QuyTrinhBanHang = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.btn_nextNTT = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_NBH = new Guna.UI.WinForms.GunaAdvenceButton();
            this.HoanThanh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.QuyTrinhBanHang.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuyTrinhBanHang
            // 
            this.QuyTrinhBanHang.Controls.Add(this.tab1);
            this.QuyTrinhBanHang.Controls.Add(this.tab2);
            this.QuyTrinhBanHang.Controls.Add(this.tab3);
            this.QuyTrinhBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuyTrinhBanHang.Location = new System.Drawing.Point(0, 0);
            this.QuyTrinhBanHang.Name = "QuyTrinhBanHang";
            this.QuyTrinhBanHang.SelectedIndex = 0;
            this.QuyTrinhBanHang.Size = new System.Drawing.Size(1169, 674);
            this.QuyTrinhBanHang.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btn_nextNTT);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1161, 645);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "ChonMua";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.btn_NBH);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1161, 645);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "NhapThongTinKH";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.HoanThanh);
            this.tab3.Location = new System.Drawing.Point(4, 25);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(1161, 645);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "NhapBaoHanh";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // btn_nextNTT
            // 
            this.btn_nextNTT.AnimationHoverSpeed = 0.07F;
            this.btn_nextNTT.AnimationSpeed = 0.03F;
            this.btn_nextNTT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_nextNTT.BorderColor = System.Drawing.Color.Black;
            this.btn_nextNTT.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_nextNTT.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_nextNTT.CheckedForeColor = System.Drawing.Color.White;
            this.btn_nextNTT.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_nextNTT.CheckedImage")));
            this.btn_nextNTT.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_nextNTT.FocusedColor = System.Drawing.Color.Empty;
            this.btn_nextNTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_nextNTT.ForeColor = System.Drawing.Color.White;
            this.btn_nextNTT.Image = null;
            this.btn_nextNTT.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_nextNTT.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_nextNTT.Location = new System.Drawing.Point(973, 595);
            this.btn_nextNTT.Name = "btn_nextNTT";
            this.btn_nextNTT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_nextNTT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_nextNTT.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_nextNTT.OnHoverImage = null;
            this.btn_nextNTT.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_nextNTT.OnPressedColor = System.Drawing.Color.Black;
            this.btn_nextNTT.Size = new System.Drawing.Size(180, 42);
            this.btn_nextNTT.TabIndex = 0;
            this.btn_nextNTT.Text = "Tiếp tục";
            this.btn_nextNTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_nextNTT.Click += new System.EventHandler(this.btn_nextNTT_Click);
            // 
            // btn_NBH
            // 
            this.btn_NBH.AnimationHoverSpeed = 0.07F;
            this.btn_NBH.AnimationSpeed = 0.03F;
            this.btn_NBH.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_NBH.BorderColor = System.Drawing.Color.Black;
            this.btn_NBH.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_NBH.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_NBH.CheckedForeColor = System.Drawing.Color.White;
            this.btn_NBH.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_NBH.CheckedImage")));
            this.btn_NBH.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_NBH.FocusedColor = System.Drawing.Color.Empty;
            this.btn_NBH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_NBH.ForeColor = System.Drawing.Color.White;
            this.btn_NBH.Image = null;
            this.btn_NBH.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_NBH.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_NBH.Location = new System.Drawing.Point(973, 595);
            this.btn_NBH.Name = "btn_NBH";
            this.btn_NBH.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_NBH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_NBH.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_NBH.OnHoverImage = null;
            this.btn_NBH.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_NBH.OnPressedColor = System.Drawing.Color.Black;
            this.btn_NBH.Size = new System.Drawing.Size(180, 42);
            this.btn_NBH.TabIndex = 1;
            this.btn_NBH.Text = "Tiếp tục";
            this.btn_NBH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_NBH.Click += new System.EventHandler(this.btn_NBH_Click);
            // 
            // HoanThanh
            // 
            this.HoanThanh.AnimationHoverSpeed = 0.07F;
            this.HoanThanh.AnimationSpeed = 0.03F;
            this.HoanThanh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.HoanThanh.BorderColor = System.Drawing.Color.Black;
            this.HoanThanh.CheckedBaseColor = System.Drawing.Color.Gray;
            this.HoanThanh.CheckedBorderColor = System.Drawing.Color.Black;
            this.HoanThanh.CheckedForeColor = System.Drawing.Color.White;
            this.HoanThanh.CheckedImage = ((System.Drawing.Image)(resources.GetObject("HoanThanh.CheckedImage")));
            this.HoanThanh.CheckedLineColor = System.Drawing.Color.DimGray;
            this.HoanThanh.FocusedColor = System.Drawing.Color.Empty;
            this.HoanThanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HoanThanh.ForeColor = System.Drawing.Color.White;
            this.HoanThanh.Image = null;
            this.HoanThanh.ImageSize = new System.Drawing.Size(20, 20);
            this.HoanThanh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.HoanThanh.Location = new System.Drawing.Point(973, 595);
            this.HoanThanh.Name = "HoanThanh";
            this.HoanThanh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.HoanThanh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.HoanThanh.OnHoverForeColor = System.Drawing.Color.White;
            this.HoanThanh.OnHoverImage = null;
            this.HoanThanh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.HoanThanh.OnPressedColor = System.Drawing.Color.Black;
            this.HoanThanh.Size = new System.Drawing.Size(180, 42);
            this.HoanThanh.TabIndex = 2;
            this.HoanThanh.Text = "Tiếp tục";
            this.HoanThanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HoanThanh.Click += new System.EventHandler(this.HoanThanh_Click);
            // 
            // frombanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 674);
            this.Controls.Add(this.QuyTrinhBanHang);
            this.Name = "frombanhang";
            this.Text = "frombanhang";
            this.QuyTrinhBanHang.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl QuyTrinhBanHang;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_nextNTT;
        private Guna.UI.WinForms.GunaAdvenceButton btn_NBH;
        private Guna.UI.WinForms.GunaAdvenceButton HoanThanh;
    }
}
namespace BanHangSieuThi.GUI
{
    partial class thongke
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_thongke = new Guna.UI.WinForms.GunaDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_SP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NSX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê kho hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgv_thongke
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_thongke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_thongke.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgv_thongke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_thongke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_thongke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_thongke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_thongke.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_thongke.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_thongke.EnableHeadersVisualStyles = false;
            this.dtgv_thongke.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_thongke.Location = new System.Drawing.Point(13, 177);
            this.dtgv_thongke.Name = "dtgv_thongke";
            this.dtgv_thongke.ReadOnly = true;
            this.dtgv_thongke.RowHeadersVisible = false;
            this.dtgv_thongke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgv_thongke.RowTemplate.Height = 30;
            this.dtgv_thongke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_thongke.Size = new System.Drawing.Size(978, 330);
            this.dtgv_thongke.TabIndex = 2;
            this.dtgv_thongke.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_thongke.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_thongke.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtgv_thongke.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_thongke.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dtgv_thongke.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_thongke.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.dtgv_thongke.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_thongke.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_thongke.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgv_thongke.ThemeStyle.ReadOnly = true;
            this.dtgv_thongke.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_thongke.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_thongke.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_thongke.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv_thongke.ThemeStyle.RowsStyle.Height = 30;
            this.dtgv_thongke.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_thongke.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv_thongke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_thongke_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sản phẩm";
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(210, 80);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(123, 22);
            this.txt_MaSP.TabIndex = 4;
            // 
            // txt_SP
            // 
            this.txt_SP.Location = new System.Drawing.Point(210, 128);
            this.txt_SP.Name = "txt_SP";
            this.txt_SP.Size = new System.Drawing.Size(123, 22);
            this.txt_SP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sản phẩm";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(536, 81);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(123, 22);
            this.txt_SoLuong.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng";
            // 
            // txt_NSX
            // 
            this.txt_NSX.Location = new System.Drawing.Point(536, 126);
            this.txt_NSX.Name = "txt_NSX";
            this.txt_NSX.Size = new System.Drawing.Size(123, 22);
            this.txt_NSX.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhà sản xuất";
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(126)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1003, 519);
            this.Controls.Add(this.txt_NSX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgv_thongke);
            this.Controls.Add(this.label1);
            this.Name = "thongke";
            this.Text = "Thống kê ";
            this.Load += new System.EventHandler(this.thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dtgv_thongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_SP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NSX;
        private System.Windows.Forms.Label label5;
    }
}
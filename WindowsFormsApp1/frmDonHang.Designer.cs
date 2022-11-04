namespace WindowsFormsApp1
{
    partial class frmDonHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gunadtpNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoHDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gunadgvDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SoHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboTimKiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTaoDonHang = new Guna.UI2.WinForms.Guna2Button();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunadgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gunadtpNgayLap);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.cboMaKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoHDB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // gunadtpNgayLap
            // 
            this.gunadtpNgayLap.BackColor = System.Drawing.Color.Transparent;
            this.gunadtpNgayLap.Checked = true;
            this.gunadtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.gunadtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunadtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gunadtpNgayLap.Location = new System.Drawing.Point(746, 34);
            this.gunadtpNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunadtpNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunadtpNgayLap.Name = "gunadtpNgayLap";
            this.gunadtpNgayLap.Size = new System.Drawing.Size(275, 36);
            this.gunadtpNgayLap.TabIndex = 12;
            this.gunadtpNgayLap.UseTransparentBackground = true;
            this.gunadtpNgayLap.Value = new System.DateTime(2022, 10, 28, 0, 10, 0, 428);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(746, 97);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(275, 30);
            this.txtThanhTien.TabIndex = 11;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(200, 102);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(275, 33);
            this.cboMaKH.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thành Tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Lập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách Hàng :";
            // 
            // txtSoHDB
            // 
            this.txtSoHDB.Location = new System.Drawing.Point(200, 41);
            this.txtSoHDB.Name = "txtSoHDB";
            this.txtSoHDB.Size = new System.Drawing.Size(275, 30);
            this.txtSoHDB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số HDB :";
            // 
            // gunadgvDonHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunadgvDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunadgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunadgvDonHang.ColumnHeadersHeight = 29;
            this.gunadgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunadgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHDB,
            this.MaNV,
            this.MaKH,
            this.NgayLap,
            this.ThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunadgvDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunadgvDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunadgvDonHang.Location = new System.Drawing.Point(22, 295);
            this.gunadgvDonHang.Name = "gunadgvDonHang";
            this.gunadgvDonHang.RowHeadersVisible = false;
            this.gunadgvDonHang.RowHeadersWidth = 51;
            this.gunadgvDonHang.RowTemplate.Height = 24;
            this.gunadgvDonHang.Size = new System.Drawing.Size(1055, 347);
            this.gunadgvDonHang.TabIndex = 2;
            this.gunadgvDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunadgvDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunadgvDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunadgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunadgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunadgvDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunadgvDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunadgvDonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunadgvDonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunadgvDonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunadgvDonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunadgvDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunadgvDonHang.ThemeStyle.HeaderStyle.Height = 29;
            this.gunadgvDonHang.ThemeStyle.ReadOnly = false;
            this.gunadgvDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunadgvDonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunadgvDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunadgvDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunadgvDonHang.ThemeStyle.RowsStyle.Height = 24;
            this.gunadgvDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunadgvDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunadgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunadgvDonHang_CellClick);
            // 
            // SoHDB
            // 
            this.SoHDB.DataPropertyName = "SoHDB";
            this.SoHDB.HeaderText = "Số HDB";
            this.SoHDB.MinimumWidth = 6;
            this.SoHDB.Name = "SoHDB";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Thời Gian";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Trị Giá";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(354, 241);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(376, 36);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.cboTimKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTimKiem.ItemHeight = 30;
            this.cboTimKiem.Location = new System.Drawing.Point(84, 241);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(195, 36);
            this.cboTimKiem.TabIndex = 13;
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.BorderRadius = 10;
            this.btnTaoDonHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoDonHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoDonHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoDonHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoDonHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTaoDonHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoDonHang.Location = new System.Drawing.Point(957, 241);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(86, 36);
            this.btnTaoDonHang.TabIndex = 14;
            this.btnTaoDonHang.Text = "TẠO";
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Location = new System.Drawing.Point(841, 27);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(44, 16);
            this.lbNhanVien.TabIndex = 15;
            this.lbNhanVien.Text = "label4";
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 687);
            this.Controls.Add(this.lbNhanVien);
            this.Controls.Add(this.btnTaoDonHang);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gunadgvDonHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDonHang";
            this.Text = "Đơn hàng";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunadgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoHDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ComboBox cboMaKH;
        private Guna.UI2.WinForms.Guna2DataGridView gunadgvDonHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnTaoDonHang;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private Guna.UI2.WinForms.Guna2DateTimePicker gunadtpNgayLap;
    }
}
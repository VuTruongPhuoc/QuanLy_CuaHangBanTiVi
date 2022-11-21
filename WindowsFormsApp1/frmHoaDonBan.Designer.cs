namespace WindowsFormsApp1
{
    partial class frmHoaDonBan
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSoHDB = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKhuyenMai = new Guna.UI2.WinForms.Guna2TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvHoaDonBan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(362, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn bán ";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.dtpThoiGian);
            this.guna2GroupBox1.Controls.Add(this.txtSoHDB);
            this.guna2GroupBox1.Controls.Add(this.cboKH);
            this.guna2GroupBox1.Controls.Add(this.txtNV);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(22, 54);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(374, 270);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Thông tin hóa đơn";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thời Gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã KH | Tên KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã NV | Tên NV";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Checked = true;
            this.dtpThoiGian.CustomFormat = "dd/MM/yyyy h:mm tt";
            this.dtpThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpThoiGian.ForeColor = System.Drawing.Color.Black;
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(10, 176);
            this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpThoiGian.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpThoiGian.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(337, 29);
            this.dtpThoiGian.TabIndex = 10;
            this.dtpThoiGian.Value = new System.DateTime(2022, 6, 10, 0, 0, 0, 0);
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dtpThoiGian_ValueChanged);
            // 
            // txtSoHDB
            // 
            this.txtSoHDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoHDB.DefaultText = "";
            this.txtSoHDB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoHDB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoHDB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoHDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoHDB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoHDB.Location = new System.Drawing.Point(10, 232);
            this.txtSoHDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoHDB.Name = "txtSoHDB";
            this.txtSoHDB.PasswordChar = '\0';
            this.txtSoHDB.PlaceholderText = "";
            this.txtSoHDB.ReadOnly = true;
            this.txtSoHDB.SelectedText = "";
            this.txtSoHDB.Size = new System.Drawing.Size(337, 24);
            this.txtSoHDB.TabIndex = 9;
            // 
            // cboKH
            // 
            this.cboKH.BackColor = System.Drawing.Color.Transparent;
            this.cboKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKH.ItemHeight = 30;
            this.cboKH.Location = new System.Drawing.Point(10, 118);
            this.cboKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(338, 36);
            this.cboKH.TabIndex = 7;
            // 
            // txtNV
            // 
            this.txtNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNV.DefaultText = "";
            this.txtNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNV.Location = new System.Drawing.Point(10, 59);
            this.txtNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNV.Name = "txtNV";
            this.txtNV.PasswordChar = '\0';
            this.txtNV.PlaceholderText = "";
            this.txtNV.ReadOnly = true;
            this.txtNV.SelectedText = "";
            this.txtNV.Size = new System.Drawing.Size(337, 24);
            this.txtNV.TabIndex = 1;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox2.Controls.Add(this.txtThanhTien);
            this.guna2GroupBox2.Controls.Add(this.txtKhuyenMai);
            this.guna2GroupBox2.Controls.Add(this.numSoLuong);
            this.guna2GroupBox2.Controls.Add(this.btnThanhToan);
            this.guna2GroupBox2.Controls.Add(this.label11);
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Controls.Add(this.btnXoa);
            this.guna2GroupBox2.Controls.Add(this.btnThem);
            this.guna2GroupBox2.Controls.Add(this.txtDonGia);
            this.guna2GroupBox2.Controls.Add(this.cboSP);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(455, 54);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(364, 270);
            this.guna2GroupBox2.TabIndex = 8;
            this.guna2GroupBox2.Text = "Chi Tiết Hóa Đơn";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Location = new System.Drawing.Point(201, 180);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(131, 24);
            this.txtThanhTien.TabIndex = 25;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKhuyenMai.DefaultText = "";
            this.txtKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhuyenMai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhuyenMai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhuyenMai.Location = new System.Drawing.Point(10, 180);
            this.txtKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.PasswordChar = '\0';
            this.txtKhuyenMai.PlaceholderText = "";
            this.txtKhuyenMai.SelectedText = "";
            this.txtKhuyenMai.Size = new System.Drawing.Size(131, 24);
            this.txtKhuyenMai.TabIndex = 24;
            this.txtKhuyenMai.TextChanged += new System.EventHandler(this.txtKhuyenMai_TextChanged);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(201, 118);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(131, 23);
            this.numSoLuong.TabIndex = 23;
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.DeepPink;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(213, 220);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(119, 36);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(198, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 162);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Khuyến mãi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(198, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Đơn Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã SP | Tên SP | Tồn kho";
            // 
            // btnXoa
            // 
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.DeepPink;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(111, 220);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.DeepPink;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(10, 220);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 36);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Location = new System.Drawing.Point(10, 117);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Size = new System.Drawing.Size(131, 24);
            this.txtDonGia.TabIndex = 10;
            // 
            // cboSP
            // 
            this.cboSP.BackColor = System.Drawing.Color.Transparent;
            this.cboSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSP.ItemHeight = 30;
            this.cboSP.Location = new System.Drawing.Point(10, 59);
            this.cboSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(323, 36);
            this.cboSP.TabIndex = 10;
            this.cboSP.SelectedIndexChanged += new System.EventHandler(this.cboSP_SelectedIndexChanged);
            // 
            // dgvHoaDonBan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHoaDonBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDonBan.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvHoaDonBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDonBan.ColumnHeadersHeight = 40;
            this.dgvHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDonBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SLBan,
            this.DonGiaBan,
            this.TongTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDonBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDonBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDonBan.Location = new System.Drawing.Point(22, 346);
            this.dgvHoaDonBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.RowHeadersVisible = false;
            this.dgvHoaDonBan.RowHeadersWidth = 51;
            this.dgvHoaDonBan.RowTemplate.Height = 24;
            this.dgvHoaDonBan.Size = new System.Drawing.Size(798, 214);
            this.dgvHoaDonBan.TabIndex = 9;
            this.dgvHoaDonBan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDonBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDonBan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDonBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDonBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDonBan.ThemeStyle.BackColor = System.Drawing.Color.Ivory;
            this.dgvHoaDonBan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDonBan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDonBan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDonBan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDonBan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDonBan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDonBan.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHoaDonBan.ThemeStyle.ReadOnly = false;
            this.dgvHoaDonBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDonBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDonBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDonBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDonBan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHoaDonBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDonBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // SLBan
            // 
            this.SLBan.DataPropertyName = "SLBan";
            this.SLBan.HeaderText = "Số Lượng";
            this.SLBan.MinimumWidth = 6;
            this.SLBan.Name = "SLBan";
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn Giá";
            this.DonGiaBan.MinimumWidth = 6;
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Thành Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.DeepPink;
            this.lbThanhTien.Location = new System.Drawing.Point(631, 582);
            this.lbThanhTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(25, 24);
            this.lbThanhTien.TabIndex = 14;
            this.lbThanhTien.Text = "0 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepPink;
            this.label12.Location = new System.Drawing.Point(451, 579);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 26);
            this.label12.TabIndex = 15;
            this.label12.Text = "Thành Tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(772, 582);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "VND";
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(853, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.dgvHoaDonBan);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtNV;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtSoHDB;
        private Guna.UI2.WinForms.Guna2ComboBox cboKH;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private Guna.UI2.WinForms.Guna2ComboBox cboSP;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDonBan;
        private System.Windows.Forms.Label lbThanhTien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpThoiGian;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private Guna.UI2.WinForms.Guna2TextBox txtKhuyenMai;
        private System.Windows.Forms.NumericUpDown numSoLuong;
    }
}
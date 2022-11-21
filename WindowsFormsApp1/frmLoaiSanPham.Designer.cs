namespace WindowsFormsApp1
{
    partial class frmLoaiSanPham
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayCuoi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChartMatHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(521, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống kê loại sản phẩm";
            // 
            // dtpNgayDau
            // 
            this.dtpNgayDau.Checked = true;
            this.dtpNgayDau.CustomFormat = "yyyy/MM//dd";
            this.dtpNgayDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDau.Location = new System.Drawing.Point(490, 86);
            this.dtpNgayDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayDau.Name = "dtpNgayDau";
            this.dtpNgayDau.Size = new System.Drawing.Size(188, 36);
            this.dtpNgayDau.TabIndex = 3;
            this.dtpNgayDau.Value = new System.DateTime(2022, 11, 15, 1, 41, 12, 271);
            this.dtpNgayDau.ValueChanged += new System.EventHandler(this.dtpNgayDau_ValueChanged);
            // 
            // dtpNgayCuoi
            // 
            this.dtpNgayCuoi.Checked = true;
            this.dtpNgayCuoi.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayCuoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayCuoi.Location = new System.Drawing.Point(787, 86);
            this.dtpNgayCuoi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayCuoi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayCuoi.Name = "dtpNgayCuoi";
            this.dtpNgayCuoi.Size = new System.Drawing.Size(200, 36);
            this.dtpNgayCuoi.TabIndex = 4;
            this.dtpNgayCuoi.Value = new System.DateTime(2022, 11, 15, 1, 38, 32, 374);
            this.dtpNgayCuoi.ValueChanged += new System.EventHandler(this.dtpNgayCuoi_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Từ Ngày";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ChartMatHang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChartDoanhThu, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 205);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1358, 485);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // ChartMatHang
            // 
            this.ChartMatHang.BackColor = System.Drawing.Color.Bisque;
            this.ChartMatHang.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.ChartMatHang.ChartAreas.Add(chartArea1);
            this.ChartMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.ChartMatHang.Legends.Add(legend1);
            this.ChartMatHang.Location = new System.Drawing.Point(4, 4);
            this.ChartMatHang.Name = "ChartMatHang";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.OrangeRed;
            series1.Legend = "Legend1";
            series1.LegendText = "Số Lượng";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "SoLuong";
            this.ChartMatHang.Series.Add(series1);
            this.ChartMatHang.Size = new System.Drawing.Size(671, 477);
            this.ChartMatHang.TabIndex = 0;
            this.ChartMatHang.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Mặt hàng bán ra";
            this.ChartMatHang.Titles.Add(title1);
            // 
            // ChartDoanhThu
            // 
            this.ChartDoanhThu.BackColor = System.Drawing.Color.Bisque;
            this.ChartDoanhThu.BorderlineColor = System.Drawing.Color.Bisque;
            chartArea2.Name = "ChartArea1";
            this.ChartDoanhThu.ChartAreas.Add(chartArea2);
            this.ChartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ChartDoanhThu.Legends.Add(legend2);
            this.ChartDoanhThu.Location = new System.Drawing.Point(682, 4);
            this.ChartDoanhThu.Name = "ChartDoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "TenSP";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.ChartDoanhThu.Series.Add(series2);
            this.ChartDoanhThu.Size = new System.Drawing.Size(672, 477);
            this.ChartDoanhThu.TabIndex = 1;
            this.ChartDoanhThu.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Doanh thu của từng mặt hàng";
            this.ChartDoanhThu.Titles.Add(title2);
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1358, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayCuoi);
            this.Controls.Add(this.dtpNgayDau);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiSanPham";
            this.Text = "frmLoaiSanPham";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayDau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayCuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMatHang;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDoanhThu;
    }
}
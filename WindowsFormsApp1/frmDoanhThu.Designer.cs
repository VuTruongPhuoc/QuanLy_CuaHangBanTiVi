namespace WindowsFormsApp1
{
    partial class frmDoanhThu
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
            this.ChartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboDoanhThu = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartDoanhThu
            // 
            this.ChartDoanhThu.BackImageTransparentColor = System.Drawing.Color.White;
            this.ChartDoanhThu.BackSecondaryColor = System.Drawing.Color.White;
            this.ChartDoanhThu.BorderlineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.AxisX.LineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.RosyBrown;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.OrangeRed;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea1.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            this.ChartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 12;
            legend1.BackColor = System.Drawing.Color.White;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.ChartDoanhThu.Legends.Add(legend1);
            this.ChartDoanhThu.Location = new System.Drawing.Point(65, 145);
            this.ChartDoanhThu.Name = "ChartDoanhThu";
            this.ChartDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.BorderColor = System.Drawing.Color.DeepPink;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.SystemColors.Highlight;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.Gainsboro;
            series1.Legend = "Legend1";
            series1.LegendText = "Doanh Thu";
            series1.Name = "DoanhThu";
            series1.ShadowColor = System.Drawing.Color.LavenderBlush;
            this.ChartDoanhThu.Series.Add(series1);
            this.ChartDoanhThu.Size = new System.Drawing.Size(1095, 473);
            this.ChartDoanhThu.TabIndex = 0;
            this.ChartDoanhThu.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            title1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            title1.BorderColor = System.Drawing.Color.White;
            title1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Teal;
            title1.Name = "Title1";
            title1.Text = "Đồ thị doanh thu năm 2022";
            this.ChartDoanhThu.Titles.Add(title1);
            // 
            // cboDoanhThu
            // 
            this.cboDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.cboDoanhThu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDoanhThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoanhThu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDoanhThu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDoanhThu.ItemHeight = 30;
            this.cboDoanhThu.Location = new System.Drawing.Point(65, 76);
            this.cboDoanhThu.Name = "cboDoanhThu";
            this.cboDoanhThu.Size = new System.Drawing.Size(168, 36);
            this.cboDoanhThu.TabIndex = 1;
            this.cboDoanhThu.SelectedIndexChanged += new System.EventHandler(this.cboDoanhThu_SelectedIndexChanged);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 666);
            this.Controls.Add(this.cboDoanhThu);
            this.Controls.Add(this.ChartDoanhThu);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDoanhThu;
        private Guna.UI2.WinForms.Guna2ComboBox cboDoanhThu;
    }
}
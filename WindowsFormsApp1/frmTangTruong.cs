using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace WindowsFormsApp1
{
    public partial class frmTangTruong : Form
    {
        BUS.BUS_ThongKe bus_dt = new BUS_ThongKe();
        public frmTangTruong()
        {
            InitializeComponent();
        }
        public void addcombobox()
        {
            cboDoanhThu.Items.Add("Theo tháng");
            cboDoanhThu.Items.Add("Theo từng quý");
            cboDoanhThu.Items.Add("Theo năm");
            
        }

        private void cboDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cboDoanhThu.SelectedIndex == 0)
            {
                ChartDoanhThu.Series["DoanhThu"].Points.Clear();
                DataTable dt = new DataTable();
                try
                {
                    dt = bus_dt.DoanhThuTheoThang(Int16.Parse(cboThang.SelectedItem.ToString().Trim()), Int16.Parse(cboNam.SelectedItem.ToString().Trim()));
                    
                }
                catch { }
                ChartDoanhThu.Series["DoanhThu"].LegendText = "DoanhThu";
                ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 3;
                ChartDoanhThu.Titles["Title1"].Text = "Đồ thị doanh thu tháng " + cboThang.SelectedItem.ToString() + "/" + cboNam.SelectedItem.ToString();
                for (int i = 1; i < dt.Columns.Count+1; i++)
                {
                    ChartDoanhThu.Series["DoanhThu"].Points.AddXY(i, dt.Rows[0]["Ngay" + i]);
                }
                ChartDoanhThu.Show();
                
            }
            if(cboDoanhThu.SelectedIndex == 1)
            {
                ChartDoanhThu.Series["DoanhThu"].Points.Clear();
                DataTable dt = new DataTable();
                try
                {
                    dt = bus_dt.DoanhThuTheoTungQuy(Int32.Parse(cboNam.SelectedItem.ToString()));
                }
                catch { }             
                ChartDoanhThu.Series["DoanhThu"].LegendText = "DoanhThu";
                ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                ChartDoanhThu.Titles["Title1"].Text = "Đồ thị doanh thu từng quý năm "+cboNam.SelectedItem.ToString();
                for (int i = 1; i < dt.Columns.Count+1; i++)
                {
                    ChartDoanhThu.Series["DoanhThu"].Points.AddXY(i, dt.Rows[0]["Quy" + i]);
                }
                ChartDoanhThu.Show();
            }
            if(cboDoanhThu.SelectedIndex == 2)
            {
                ChartDoanhThu.Series["DoanhThu"].Points.Clear();
                DataTable dt = new DataTable();
                try
                {
                    dt = bus_dt.HienThiDoanhThu(Int32.Parse(cboNam.SelectedItem.ToString()));
                }
                catch { }               
                ChartDoanhThu.Series["DoanhThu"].LegendText = "DoanhThu";
                ChartDoanhThu.Titles["Title1"].Text = "Đồ thị doanh thu năm "+ cboNam.SelectedItem.ToString();
                ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                for (int i = 1; i < dt.Columns.Count+1; i++)
                {
                    ChartDoanhThu.Series["DoanhThu"].Points.AddXY(i, dt.Rows[0]["Thang" + i]);
                }
            }
        }
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            for(int i = 2017;i < 2024; i++)
            {
                cboNam.Items.Add(i);
            }
            for (int i = 1; i < 13; i++)
            {
                cboThang.Items.Add(i);
            }
            addcombobox();
            cboThang.SelectedIndex = 10;
            cboNam.SelectedIndex = 5;
        }
    }
}

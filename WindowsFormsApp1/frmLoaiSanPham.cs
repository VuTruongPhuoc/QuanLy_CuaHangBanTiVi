using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{ 
    public partial class frmLoaiSanPham : Form
    {
        BUS.BUS_ThongKe bus_tk = new BUS_ThongKe();
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            dtpNgayDau.Value = DateTime.Parse("2022/1/1");
        }

        private void dtpNgayDau_ValueChanged(object sender, EventArgs e)
        {
            //doanh thu
            ChartDoanhThu.Series["TenSP"].Points.Clear();
            try
            {
                ChartDoanhThu.DataSource = bus_tk.DoanhThuMatHang(DateTime.Parse(dtpNgayDau.Value.ToString()), DateTime.Parse(dtpNgayCuoi.Value.ToString()));
            }
            catch { }
            ChartDoanhThu.Series["TenSP"].XValueMember = "TenSP";
            ChartDoanhThu.Series["TenSP"].YValueMembers = "DoanhThu";
            ChartDoanhThu.Show();
            //so luong
            ChartMatHang.Series["SoLuong"].Points.Clear();
            DataTable dt = new DataTable();
            dt = bus_tk.SoLuongMatHangBan(DateTime.Parse(dtpNgayDau.Value.ToString()), DateTime.Parse(dtpNgayCuoi.Value.ToString()));
            ChartMatHang.Titles["Title1"].Text = "Đồ thị mặt hàng bán ra";
            ChartMatHang.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChartMatHang.Series["SoLuong"].Points.AddXY(dt.Rows[i]["TenSP"], dt.Rows[i]["SoLuongBan"]);
            }
        }

        private void dtpNgayCuoi_ValueChanged(object sender, EventArgs e)
        {
            //doanh thu
            ChartDoanhThu.Series["TenSP"].Points.Clear();
            try
            {
                ChartDoanhThu.DataSource = bus_tk.DoanhThuMatHang(DateTime.Parse(dtpNgayDau.Value.ToString()), DateTime.Parse(dtpNgayCuoi.Value.ToString()));
            }
            catch { }
            ChartDoanhThu.Series["TenSP"].XValueMember = "TenSP";
            ChartDoanhThu.Series["TenSP"].YValueMembers = "DoanhThu";
            ChartDoanhThu.Show();
            //so luong
            ChartMatHang.Series["SoLuong"].Points.Clear();
            DataTable dt = new DataTable();
            dt = bus_tk.SoLuongMatHangBan(DateTime.Parse(dtpNgayDau.Value.ToString()), DateTime.Parse(dtpNgayCuoi.Value.ToString()));
            ChartMatHang.Titles["Title1"].Text = "Đồ thị mặt hàng bán ra";
            ChartMatHang.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChartMatHang.Series["SoLuong"].Points.AddXY(dt.Rows[i]["TenSP"], dt.Rows[i]["SoLuongBan"]);
            }
        }

    }
}

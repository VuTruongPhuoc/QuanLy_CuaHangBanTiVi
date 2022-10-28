using BUS;
using Guna.UI2.WinForms;
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
    public partial class frmHoaDon : Form
    {
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        frmDangNhap frmDangNhap = new frmDangNhap();
        Resources.CommonFunction comm = new Resources.CommonFunction();
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_SanPham bus_sp = new BUS_SanPham();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bus_hd.HienThiNV(frmDangNhap.taikhoan);
            txtNV.Text = dt.Rows[0]["MaNV"].ToString().Trim() + " | " + dt.Rows[0]["TenNV"].ToString().Trim();
            comm.FillCombo(bus_hd.HienThiKH(), cboKH, "TTKH", "MaKH");

            Random rd = new Random();
            txtSoHD.Text = "HDB" + rd.Next(1, 100).ToString();
            
            DataTable dt2 = new DataTable();
            dt2 = bus_sp.HienThiSanPham();
            for(int i = 0; i< dt2.Rows.Count; i++)
            {
                cboSP.Items.Add(dt2.Rows[i][1].ToString() + " | " + dt2.Rows[i][5].ToString());
            }

        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str = cboSP.SelectedItem.ToString();
            string[] a = str.Split('|');
            string TenSP = a[0].Trim();
            DataTable dt = new DataTable();
            dt = bus_hd.HienThiGiaSP(TenSP);
            txtDonGia.Text = dt.Rows[0]["DonGiaBan"].ToString().Trim();

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, gg;
            try
            {
                if (txtSoLuong.Text == "")
                    sl = 0;
                else
                    sl = Double.Parse(txtSoLuong.Text);
                if (txtKhuyenMai.Text == "")
                    gg = 0;
                else
                    gg = Double.Parse(txtKhuyenMai.Text);
                if (txtDonGia.Text == "")
                    dg = 0;
                else
                    dg = Double.Parse(txtDonGia.Text);
                txtThanhTien.Text = ((sl * dg) - sl * dg * gg / 100).ToString();
            }
            catch { }
            

        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, gg;
            try
            {
                if (txtSoLuong.Text == "")
                    sl = 0;
                else
                    sl = Double.Parse(txtSoLuong.Text);
                if (txtKhuyenMai.Text == "")
                    gg = 0;
                else
                    gg = Double.Parse(txtKhuyenMai.Text);
                if (txtDonGia.Text == "")
                    dg = 0;
                else
                    dg = Double.Parse(txtDonGia.Text);
                txtThanhTien.Text = ((sl * dg) - sl * dg * gg / 100).ToString();
            }
            catch { }
        }
    }
}

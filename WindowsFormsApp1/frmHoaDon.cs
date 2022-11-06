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
using DTO;

namespace WindowsFormsApp1
{
    public partial class frmHoaDon : Form
    {
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        frmDangNhap frmDangNhap = new frmDangNhap();
        Resources.CommonFunction comm = new Resources.CommonFunction();
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_SanPham bus_sp = new BUS_SanPham();
        DTO_HoaDon dto_hd = new DTO_HoaDon();
        BUS_DonHang bus_dh = new BUS_DonHang();
        DTO_DonHang dto_dh = new DTO_DonHang();
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
            dtpThoiGian.Value = DateTime.Now;
            Random rd = new Random();
            txtSoHD.Text = "HDB" + rd.Next(1, 1000).ToString();
            
            DataTable dt2 = new DataTable();
            dt2 = bus_sp.HienThiSanPham();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cboSP.Items.Add(dt2.Rows[i][0].ToString() + " | " + dt2.Rows[i][1].ToString() + " | " + dt2.Rows[i][5].ToString());
            }
            bus_dh.ThemDonHang(txtSoHD.Text, null, null, dtpThoiGian.Value.ToString(), 0);
        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str = cboSP.SelectedItem.ToString();
            string[] a = str.Split('|');
            string TenSP = a[1].Trim();
            DataTable dt = new DataTable();
            dt = bus_hd.HienThiDonGia(TenSP);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            String str = cboSP.SelectedItem.ToString();
            string[] a = str.Split('|');
            string TenSP = a[1].Trim();
            DataTable dt = new DataTable();
            dt = bus_hd.HienThiSP(TenSP);
            try
            {
                dto_hd.Sohdb = txtSoHD.Text.ToString();
                dto_hd.Masp = dt.Rows[0]["MaSP"].ToString().Trim();
                dto_hd.Slban = Int16.Parse(txtSoLuong.Text.ToString().Trim());
                dto_hd.Km = txtKhuyenMai.Text.ToString();

                bus_hd.ThemCTHD(dto_hd.Sohdb, dto_hd.Masp, dto_hd.Slban, dto_hd.Km);
                MessageBox.Show("Thêm thành công!");
                gunadgvHoaDon.DataSource = bus_hd.HienThiCTHoaDon(dto_hd.Sohdb);

            }
            catch { MessageBox.Show("Lỗi"); }
            DataTable dt3 = new DataTable();
            dt3 = bus_hd.HienThiThanhTien(txtSoHD.Text);
            lbThanhTien.Text = dt3.Rows[0]["ThanhTien"].ToString().Trim();
        }
        string masp;
        private void gunadgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               masp = gunadgvHoaDon.CurrentRow.Cells["MaSP"].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dto_hd.Sohdb = txtSoHD.Text.ToString().Trim();
                dto_hd.Masp = masp.Trim();
            }
            catch { }
            bus_hd.XoaSP(dto_hd.Sohdb, dto_hd.Masp);
            MessageBox.Show("Xóa thành công!");
            gunadgvHoaDon.DataSource = bus_hd.HienThiCTHoaDon(dto_hd.Sohdb);
            DataTable dt = new DataTable();
            dt = bus_hd.HienThiThanhTien(txtSoHD.Text);
            lbThanhTien.Text = dt.Rows[0]["ThanhTien"].ToString().Trim();
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            String str = cboKH.SelectedValue.ToString();
            string[] a = str.Split('|');
            string makh = a[0].ToString();
            DataTable dt = new DataTable();
            dt = bus_dh.HienThiMaNV(frmDangNhap.taikhoan);
            //try
            //{
                dto_dh.Sohdb1 = txtSoHD.Text.ToString().Trim();
                dto_dh.Manv = dt.Rows[0]["MaNV"].ToString().Trim();
                dto_dh.Makh = makh;
                dto_dh.Thanhtien = double.Parse(lbThanhTien.Text.ToString().Trim());
            //}
            //catch { }
            bus_dh.SuaDonHang(dto_dh.Sohdb1, dto_dh.Manv, dto_dh.Makh,dto_dh.Thanhtien);
            MessageBox.Show("Thanh toán thành công!!");
        }

       
    }
}

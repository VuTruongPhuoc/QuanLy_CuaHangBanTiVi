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
using DTO;

namespace WindowsFormsApp1
{
    public partial class frmHoaDonNhap : Form
    {
        BUS.BUS_HoaDonNhap bus_hdn = new BUS_HoaDonNhap();
        BUS_SanPham bus_sp = new BUS_SanPham();
        BUS_DonNhap bus_nh = new BUS_DonNhap();
        DTO_HoaDonNhap dto_hdn = new DTO_HoaDonNhap();
        DTO_DonNhap dto_nh = new DTO_DonNhap();
        
        Resources.CommonFunction comm = new Resources.CommonFunction();
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bus_hdn.HienThiNV(frmDangNhap.taikhoan);
            txtNV.Text = dt.Rows[0]["MaNV"].ToString().Trim() + " | " + dt.Rows[0]["TenNV"].ToString().Trim();
            comm.FillCombo(bus_hdn.HienThiNCC(), cboNCC, "TTNCC", "MaNCC");
            dtpThoiGian.Value = DateTime.Now;
            Random rd = new Random();
            txtSoHD.Text = "HDN" + rd.Next(1, 1000).ToString();

            DataTable dt2 = new DataTable();
            dt2 = bus_sp.HienThiSanPham();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cboSP.Items.Add(dt2.Rows[i][0].ToString() + " | " + dt2.Rows[i][1].ToString());
            }
            bus_nh.ThemDonNhap(txtSoHD.Text, null, null, dtpThoiGian.Value.ToString(), 0);
        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {         
             String str = cboSP.SelectedItem.ToString();
             string[] a = str.Split('|');
             string TenSP = a[1].Trim();
             DataTable dt = new DataTable();
             dt = bus_hdn.HienThiSP(TenSP);
             txtDonGia.Text = dt.Rows[0]["DonGiaNhap"].ToString().Trim();
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
            dt = bus_hdn.HienThiSP(TenSP);
            try
            {
                dto_hdn.Sohdn = txtSoHD.Text.ToString();
                dto_hdn.Masp = dt.Rows[0]["MaSP"].ToString().Trim();
                dto_hdn.Sl = Int16.Parse(txtSoLuong.Text.ToString().Trim());
                dto_hdn.Km = double.Parse(txtKhuyenMai.Text.ToString());

                bus_hdn.ThemCTHDN(dto_hdn.Sohdn, dto_hdn.Masp, dto_hdn.Sl, dto_hdn.Km);
                MessageBox.Show("Thêm thành công!");
                dgvHoaDonNhap.DataSource = bus_hdn.HienThiCTHDN(dto_hdn.Sohdn);

            }
            catch { MessageBox.Show("Lỗi"); }
            DataTable dt3 = new DataTable();
            dt3 = bus_hdn.HienThiThanhTien(txtSoHD.Text);
            lbThanhTien.Text = dt3.Rows[0]["ThanhTien"].ToString().Trim();
        }
        string masp;
        private void gunadgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            masp = dgvHoaDonNhap.CurrentRow.Cells["MaSP"].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dto_hdn.Sohdn = txtSoHD.Text.ToString().Trim();
                dto_hdn.Masp = masp.Trim();
            }
            catch { }
            bus_hdn.XoaSP(dto_hdn.Sohdn, dto_hdn.Masp);
            MessageBox.Show("Xóa thành công!");
            dgvHoaDonNhap.DataSource = bus_hdn.HienThiCTHDN(dto_hdn.Sohdn);
            DataTable dt = new DataTable();
            dt = bus_hdn.HienThiThanhTien(txtSoHD.Text);
            lbThanhTien.Text = dt.Rows[0]["ThanhTien"].ToString().Trim();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            String str = cboNCC.SelectedValue.ToString();
            string[] a = str.Split('|');
            string mancc = a[0].ToString();
            DataTable dt = new DataTable();
            dt = bus_nh.HienThiMaNV(frmDangNhap.taikhoan);
            try
            {
                dto_nh.Sohdn = txtSoHD.Text.ToString().Trim();
                dto_nh.Mancc = mancc;
                dto_nh.Manv = dt.Rows[0]["MaNV"].ToString().Trim();               
                dto_nh.Thanhtien = double.Parse(lbThanhTien.Text.ToString().Trim());
            }
            catch { }
            bus_nh.SuaDonNhap(dto_nh.Sohdn,  dto_nh.Mancc, dto_nh.Manv, dto_nh.Thanhtien);
            MessageBox.Show("Thanh toán thành công!!");

            frmDonNhap frmDonNhap = new frmDonNhap();
            this.Close();
        }
    }
}

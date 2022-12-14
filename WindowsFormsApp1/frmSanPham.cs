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
using DTO;

namespace WindowsFormsApp1
{
    public partial class frmSanPham : Form
    {
        BUS.BUS_SanPham bussp = new BUS.BUS_SanPham();
        DTO.DTO_SanPham dtosp = new DTO.DTO_SanPham();
        BUS.BUS_ThuongHieu bus_th = new BUS_ThuongHieu();
        Resources.CommonFunction comm = new Resources.CommonFunction();

        public frmSanPham()
        {
            InitializeComponent();
        }
        public void LamMoi()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cboThuongHieuSX.SelectedIndex = -1;
            cboKichThuoc.SelectedIndex = -1;
            cboManHinh.SelectedIndex = -1;
            numUDSoLuong.Value = 0;
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtGhiChu.Text = "";
        }
        public void ThemcboKichThuoc()
        {
            cboKichThuoc.Items.Add("8 inch");
            cboKichThuoc.Items.Add("16 inch");
            cboKichThuoc.Items.Add("24 inch");
            cboKichThuoc.Items.Add("32 inch");
            cboKichThuoc.Items.Add("40 inch");
            cboKichThuoc.Items.Add("48 inch");
            cboKichThuoc.Items.Add("56 inch");
            cboKichThuoc.Items.Add("64 inch");
            cboKichThuoc.Items.Add("72 inch");
            cboKichThuoc.Items.Add("80 inch");

        }
        public void ThemcboManHinh()
        {
            cboManHinh.Items.Add("Màn Hình Cong");
            cboManHinh.Items.Add("TV 8K");
            cboManHinh.Items.Add("OLED");
            cboManHinh.Items.Add("OLED evo");
            cboManHinh.Items.Add("TV NanoCell");
            cboManHinh.Items.Add("Quantum Dot");
            cboManHinh.Items.Add("Plasma TV");
            cboManHinh.Items.Add("Direct LED");
            cboManHinh.Items.Add("Edge LED");


        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            comm.FillCombo(bus_th.HienThiTH(), cboThuongHieuSX, "TenTH", "MaTH");
            ThemcboKichThuoc();
            ThemcboManHinh();
            LamMoi();
            dgvSanPham.DataSource = bussp.HienThiSanPham();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            if (txtMaSP.TextLength == 0) { MessageBox.Show("Vui lòng nhập Mã SP !", "Thông báo");txtMaSP.Focus(); return; }
            else if (txtTenSP.TextLength == 0) { MessageBox.Show("Vui lòng nhập Tên SP !", "Thông báo"); txtTenSP.Focus(); return; }
            else if (cboThuongHieuSX.SelectedIndex == -1) { MessageBox.Show("Vui lòng nhập Thương Hiệu SX !", "Thông báo"); cboThuongHieuSX.Focus(); return; }
            else if (cboKichThuoc.SelectedIndex == -1) { MessageBox.Show("Vui lòng nhập Kích Thước SP !", "Thông báo"); cboKichThuoc.Focus(); return; }
            else if (cboManHinh.SelectedIndex == -1) { MessageBox.Show("Vui lòng nhập Màn hình SP !", "Thông báo"); cboManHinh.Focus(); return; }
            else if (numUDSoLuong.Value == 0) { MessageBox.Show("Vui lòng nhập Số Lượng SP !", "Thông báo"); numUDSoLuong.Focus(); return; }
            else if (txtDonGiaNhap.TextLength == 0) { MessageBox.Show("Vui Lòng Nhập Đơn Giá Nhập của SP", "Thông báo"); txtDonGiaNhap.Focus(); return; }
            else if (txtDonGiaBan.TextLength == 0) { MessageBox.Show("Vui lòng nhập Đơn Giá Bán của SP"); txtDonGiaBan.Focus(); return; }
            
            try
            {
                a = double.Parse(txtDonGiaNhap.Text.Trim());
                b = double.Parse(txtDonGiaBan.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Dữ Liệu Đơn Giá Nhập và Đơn Giá Bán phải là số", "Thông báo");
                return;
            }
            if (bussp.KiemTraTrungMaSP(txtMaSP.Text))
            {
                MessageBox.Show("Mã Sản Phẩm đã có, vui lòng nhập lại !");
                txtMaSP.Focus();
                return;
            }
            if (a >= b) { MessageBox.Show("Đơn Giá Bán phải lón hơn Đơn Giá Nhập , vui lòng nhập lại !", "Thông báo"); return; };
            try
            {
                dtosp.MaSP1 = txtMaSP.Text.Trim();
                dtosp.TenSP1 = txtTenSP.Text.Trim();
                dtosp.MaTH1 = cboThuongHieuSX.SelectedValue.ToString().Trim();
                dtosp.KichThuoc1 = cboKichThuoc.SelectedItem.ToString().Trim();
                dtosp.ManHinh1 = cboManHinh.SelectedItem.ToString().Trim();
                dtosp.SoLuong1 = Convert.ToInt32(numUDSoLuong.Value);
                dtosp.DonGiaNhap1 = double.Parse(txtDonGiaNhap.Text.Trim());
                dtosp.DonGiaBan1 = double.Parse(txtDonGiaBan.Text.Trim());
                dtosp.HinhAnh1 = DuongdanAnh;
                dtosp.GhiChu1 = txtGhiChu.Text.Trim();

                bussp.ThemSanPham(dtosp.MaSP1, dtosp.TenSP1, dtosp.MaTH1, dtosp.KichThuoc1, dtosp.ManHinh1, dtosp.SoLuong1, dtosp.DonGiaNhap1, dtosp.DonGiaBan1, dtosp.HinhAnh1, dtosp.GhiChu1);
                MessageBox.Show("Thêm thành công", "Thông báo");
                dgvSanPham.DataSource = bussp.HienThiSanPham();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            try
            {
                a = double.Parse(txtDonGiaNhap.Text.Trim());
                b = double.Parse(txtDonGiaBan.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Dữ Liệu Đơn Giá Nhập và Đơn Giá Bán phải là số", "Thông báo");
                return;
            }
            if (a >= b) { MessageBox.Show("Đơn Giá Bán phải lón hơn Đơn Giá Nhập , vui lòng nhập lại !", "Thông báo"); return; };
            try
            {
                dtosp.MaSP1 = txtMaSP.Text.Trim();
                dtosp.TenSP1 = txtTenSP.Text.Trim();
                dtosp.MaTH1 = cboThuongHieuSX.SelectedValue.ToString().Trim();
                dtosp.KichThuoc1 = cboKichThuoc.SelectedItem.ToString().Trim();
                dtosp.ManHinh1 = cboManHinh.SelectedItem.ToString().Trim();
                dtosp.SoLuong1 = Convert.ToInt32(numUDSoLuong.Value);
                dtosp.DonGiaNhap1 = double.Parse(txtDonGiaNhap.Text.Trim());
                dtosp.DonGiaBan1 = double.Parse(txtDonGiaBan.Text.Trim());
                dtosp.HinhAnh1 = DuongdanAnh;
                dtosp.GhiChu1 = txtGhiChu.Text.Trim();

                bussp.SuaSanPham(dtosp.MaSP1, dtosp.TenSP1, dtosp.MaTH1, dtosp.KichThuoc1, dtosp.ManHinh1, dtosp.SoLuong1, dtosp.DonGiaNhap1, dtosp.DonGiaBan1, dtosp.HinhAnh1, dtosp.GhiChu1);
                MessageBox.Show("Sửa thành công", "Thông báo");
                dgvSanPham.DataSource = bussp.HienThiSanPham();
                LamMoi();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dtosp.MaSP1 = txtMaSP.Text.Trim();

                bussp.XoaSanPham(dtosp.MaSP1);
                dgvSanPham.DataSource = bussp.HienThiSanPham();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        string DuongdanAnh;
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlg.FileName);
                //cat chuoi ra ten anh
                DuongdanAnh = dlg.FileName.Substring(dlg.FileName.LastIndexOf('\\') + 1, dlg.FileName.Length - dlg.FileName.LastIndexOf('\\') - 1);
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = bussp.TimKiemSanPham(txtTimKiem.Text);
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSP.Text = dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells["TenSP"].Value.ToString();
                cboThuongHieuSX.SelectedValue = dgvSanPham.CurrentRow.Cells["MaTH"].Value.ToString();
                cboKichThuoc.SelectedItem = dgvSanPham.CurrentRow.Cells["KichThuoc"].Value.ToString();
                cboManHinh.SelectedItem = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                numUDSoLuong.Value = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["SoLuong"].Value);
                txtDonGiaNhap.Text = dgvSanPham.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
                txtDonGiaBan.Text = dgvSanPham.CurrentRow.Cells["DonGiaBan"].Value.ToString();
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\ImageSP\\" + dgvSanPham.CurrentRow.Cells[8].Value.ToString());
                txtGhiChu.Text = dgvSanPham.CurrentRow.Cells["GhiChu"].Value.ToString();
            }
            catch { }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}

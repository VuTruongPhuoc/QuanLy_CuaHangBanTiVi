using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp1
{
    public partial class frmNhanVien : Form
    {
        BUS.BUS_NhanVien bus_nv = new BUS.BUS_NhanVien();
        DTO.DTO_NhanVien dto_nv = new DTO.DTO_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void LamMoi()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            rdoNhanVien.Checked = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LamMoi();
            dgvNhanVien.DataSource = bus_nv.HienThiNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value;
                txtSDT.Text = dgvNhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
                if (dgvNhanVien.CurrentRow.Cells["LoaiTaiKhoan"].Value.ToString().Trim() == "0")
                {
                    rdoNhanVien.Checked = true;
                    rdoQuanTri.Checked = false;
                }
                else
                {
                    rdoNhanVien.Checked = false;
                    rdoQuanTri.Checked = true;
                }
            }
            catch { }

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.TextLength == 0) { MessageBox.Show("Vui lòng nhập Mã NV !", "Thông báo"); return; }
            else if (txtTenNV.TextLength == 0) { MessageBox.Show("Vui lòng nhập Tên NV !", "Thông báo"); return; }
            else if (dtpNgaySinh.Value == DateTime.Today) { MessageBox.Show("Vui lòng nhập ngày sinh ", "Thông báo"); return; }
            else if (txtSDT.TextLength == 0) { MessageBox.Show("Vui lòng nhập Số Điện Thoại !", "Thông báo"); return; }
            else if (txtDiaChi.TextLength == 0) { MessageBox.Show("Vui lòng nhập Địa Chỉ !", "Thông báo"); return; }
            if (!Regex.IsMatch(txtSDT.Text, @"^\d{9,11}$"))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!!", "Thông báo");
                txtSDT.Focus();
                return;
            }
            if (bus_nv.KiemTraTrungMaNV(txtMaNV.Text))
            {
                MessageBox.Show("Mã Nhân Viên đã có, vui lòng nhập lại !!");
                txtMaNV.Focus();
                return;
            }
            try
            {
                dto_nv.Manv = txtMaNV.Text.Trim();
                dto_nv.Tennv = txtTenNV.Text.Trim();
                dto_nv.Ngaysinh = dtpNgaySinh.Value.ToString();
                dto_nv.Sdt = txtSDT.Text.Trim();
                dto_nv.Diachi = txtDiaChi.Text.Trim();
                dto_nv.Tentk = txtTaiKhoan.Text.Trim();
                dto_nv.Mk = txtMatKhau.Text.Trim();
                dto_nv.Chucvu = (rdoNhanVien.Checked ? "0" : "1");


                bus_nv.ThemNhanVien(dto_nv.Manv, dto_nv.Tennv, dto_nv.Ngaysinh, dto_nv.Sdt, dto_nv.Diachi, dto_nv.Tentk, dto_nv.Mk, Int16.Parse(dto_nv.Chucvu));
                MessageBox.Show("Thêm thành công", "Thông báo");
                dgvNhanVien.DataSource = bus_nv.HienThiNhanVien();
                LamMoi();
            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dto_nv.Manv = txtMaNV.Text.Trim();
                dto_nv.Tennv = txtTenNV.Text.Trim();
                dto_nv.Ngaysinh = dtpNgaySinh.Value.ToString();
                dto_nv.Sdt = txtSDT.Text.Trim();
                dto_nv.Diachi = txtDiaChi.Text.Trim();
                dto_nv.Tentk = txtTaiKhoan.Text.Trim();
                dto_nv.Mk = txtMatKhau.Text.Trim();
                dto_nv.Chucvu = (rdoNhanVien.Checked ? "0" : "1");

                bus_nv.SuaNhanVien(dto_nv.Manv, dto_nv.Tennv, dto_nv.Ngaysinh, dto_nv.Sdt, dto_nv.Diachi, dto_nv.Tentk, dto_nv.Mk, Int16.Parse(dto_nv.Chucvu));
                MessageBox.Show("Sửa thành công", "Thông báo");
                dgvNhanVien.DataSource = bus_nv.HienThiNhanVien();

            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dto_nv.Manv = txtMaNV.Text.Trim();

                bus_nv.XoaNhanVien(dto_nv.Manv);
                MessageBox.Show("Xóa thành công", "Thông báo");
                dgvNhanVien.DataSource = bus_nv.HienThiNhanVien();

            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bus_nv.TimKiemNhanVien(txtTimKiem.Text);
        }

        
    }
}

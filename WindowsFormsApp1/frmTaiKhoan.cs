using BUS;
using DTO;
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
    public partial class frmTaiKhoan : Form
    {
        BUS.BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        frmDangNhap frmDangNhap = new frmDangNhap();
        DTO.DTO_NhanVien dto_nv = new DTO_NhanVien();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = frmDangNhap.taikhoan;
            DataTable dt = new DataTable();
            dt = bus_tk.HienThiTaiKhoan(txtTenDangNhap.Text.Trim());
            txtMaNV.Text = dt.Rows[0]["MaNV"].ToString().Trim();
            txtTenNV.Text = dt.Rows[0]["TenNV"].ToString().Trim();
            txtSDT.Text = dt.Rows[0]["DienThoai"].ToString().Trim();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString().Trim();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (bus_tk.KiemTraTrungTaiKhoan(txtTenDangNhap.Text.Trim())) { MessageBox.Show("Tài khoản này đã được đăng kí , vui lòng nhập lại !", "Thông báo"); return; }
            try
            {
                dto_nv.Manv = txtMaNV.Text;
                dto_nv.Tennv = txtTenNV.Text;
                dto_nv.Sdt = txtSDT.Text;
                dto_nv.Diachi = txtDiaChi.Text;
                dto_nv.Tentk = txtTenDangNhap.Text;

                bus_tk.SuaTaiKhoan(dto_nv.Manv, dto_nv.Tennv, dto_nv.Sdt, dto_nv.Diachi, dto_nv.Tentk);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.TextLength == 0) { MessageBox.Show("Vui lòng nhập mật khẩu !", "Thông báo"); txtMatKhauCu.Focus(); return; }
            else if (txtMatKhauMoi.TextLength == 0) { MessageBox.Show("Vui lòng nhập mật khẩu mới !", "Thông báo"); txtMatKhauMoi.Focus(); return; }
            else if (txtNhapLai.Text != txtMatKhauMoi.Text) { MessageBox.Show("Mật khẩu xác nhận không chính xác, vui lòng nhập lại!! ", "Thông báo"); txtNhapLai.Focus(); return; }
            else if (txtMatKhauCu.Text != frmDangNhap.matkhau) { MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác vui lòng nhập lại"); txtTenDangNhap.Focus(); return; }
            try
            {
                dto_nv.Tentk = txtMatKhauCu.Text;
                dto_nv.Mk = txtMatKhauMoi.Text;
                bus_tk.DoiMatKhau(txtTenDangNhap.Text, txtMatKhauMoi.Text);
                MessageBox.Show("Đổi Mật Khẩu thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }
    }
}

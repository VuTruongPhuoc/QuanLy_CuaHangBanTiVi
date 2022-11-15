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
    public partial class frmKhachHang : Form
    {
        BUS.BUS_KhachHang bus_kh = new BUS_KhachHang();
        DTO.DTO_KhachHang dto_kh = new DTO_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void LamMoi()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            rdoNam.Checked = true;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LamMoi();
            dgvKhachHang.DataSource = bus_kh.HienThiKhachHang();
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                if (dgvKhachHang.CurrentRow.Cells[2].Value.ToString().Trim() == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else
                {
                    rdoNam.Checked = false;
                    rdoNu.Checked = true;
                }
                txtSDT.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            }
            catch { }

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = bus_kh.TimKiemKhachHang(txtTimKiem.Text.Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.TextLength == 0) { MessageBox.Show("Vui lòng nhập Mã KH !", "Thông báo"); return; }
            else if (txtTenKH.TextLength == 0) { MessageBox.Show("Vui lòng nhập Tên KH !", "Thông báo"); return; }
            else if (txtSDT.TextLength == 0) { MessageBox.Show("Vui lòng nhập Số Điện Thoại !", "Thông báo"); return; }
            else if (txtDiaChi.TextLength == 0) { MessageBox.Show("Vui lòng nhập Địa Chỉ !", "Thông báo"); return; }

            if (!Regex.IsMatch(txtSDT.Text, @"^\d{9,11}$"))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!!", "Thông báo");
                txtSDT.Focus();
                return;
            }
            if (bus_kh.KiemTraTrungMaKH(txtMaKH.Text))
            {
                MessageBox.Show("Mã Sản Phẩm đã có, vui lòng nhập lại !!");
                txtMaKH.Focus();
                return;
            }
            try
            {
                dto_kh.Makh1 = txtMaKH.Text.Trim();
                dto_kh.Tenkh1 = txtTenKH.Text.Trim();
                dto_kh.GioiTinh1 = (rdoNam.Checked ? rdoNam.Text : rdoNu.Text);
                dto_kh.Sdt = txtSDT.Text.Trim();
                dto_kh.Diachi1 = txtDiaChi.Text.Trim();

                bus_kh.ThemKhachHang(dto_kh.Makh1, dto_kh.Tenkh1, dto_kh.GioiTinh1, dto_kh.Sdt, dto_kh.Diachi1);
                MessageBox.Show("Thêm thành công", "Thông báo");
                dgvKhachHang.DataSource = bus_kh.HienThiKhachHang();
                LamMoi();
            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtSDT.Text, @"^\d{9,11}$"))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!!", "Thông báo");
                txtSDT.Focus();
                return;
            }
            try
            {
                dto_kh.Makh1 = txtMaKH.Text.Trim();
                dto_kh.Tenkh1 = txtTenKH.Text.Trim();
                dto_kh.GioiTinh1 = (rdoNam.Checked ? rdoNam.Text : rdoNu.Text);
                dto_kh.Sdt = txtSDT.Text.Trim();
                dto_kh.Diachi1 = txtDiaChi.Text.Trim();

                bus_kh.SuaKhachHang(dto_kh.Makh1, dto_kh.Tenkh1, dto_kh.GioiTinh1, dto_kh.Sdt, dto_kh.Diachi1);
                MessageBox.Show("Sửa thành công", "Thông báo");
                dgvKhachHang.DataSource = bus_kh.HienThiKhachHang();

            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dto_kh.Makh1 = txtMaKH.Text.Trim();

                bus_kh.XoaKhachHang(dto_kh.Makh1);
                MessageBox.Show("Xóa thành công", "Thông báo");
                dgvKhachHang.DataSource = bus_kh.HienThiKhachHang();

            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
            LamMoi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        
    }
}

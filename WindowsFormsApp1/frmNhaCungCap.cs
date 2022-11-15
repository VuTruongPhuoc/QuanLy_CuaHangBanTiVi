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
    public partial class frmNhaCungCap : Form
    {
        BUS.BUS_NhaCungCap bus_ncc = new BUS_NhaCungCap();
        DTO.DTO_NhaCungCap dto_ncc = new DTO_NhaCungCap();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void LamMoi()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LamMoi();
            dgvNCC.DataSource = bus_ncc.HienThiNCC();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.TextLength == 0) { MessageBox.Show("Vui lòng nhập Mã NCC !", "Thông báo"); return; }
            else if (txtTenNCC.TextLength == 0) { MessageBox.Show("Vui lòng nhập Tên NCC !", "Thông báo"); return; }
            else if (txtDienThoai.TextLength == 0) { MessageBox.Show("Vui lòng nhập Số Điện Thoại !", "Thông báo"); return; }
            else if (txtDiaChi.TextLength == 0) { MessageBox.Show("Vui lòng nhập Số Điện Thoại !", "Thông báo"); return; }
            if (!Regex.IsMatch(txtDienThoai.Text, @"^\d{9,11}$"))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!!", "Thông báo");
                txtDienThoai.Focus();
                return;
            }
            if (bus_ncc.KiemTraTrungMaNCC(txtMaNCC.Text))
            {
                MessageBox.Show("Mã Nhà Cung Cấp đã tồn tại , vui lòng nhập lại!!", "Thông báo");
                txtMaNCC.Focus();
                return;
            }
            try
            {
                dto_ncc.MaNCC1 = txtMaNCC.Text.Trim();
                dto_ncc.TenNCC1 = txtTenNCC.Text.Trim();
                dto_ncc.Dt = txtDienThoai.Text.Trim();
                dto_ncc.Dc = txtDiaChi.Text.Trim();

                bus_ncc.ThemNCC(dto_ncc.MaNCC1, dto_ncc.TenNCC1, dto_ncc.Dt, dto_ncc.Dc);
                MessageBox.Show("Thêm thành công", "Thông báo");
                dgvNCC.DataSource = bus_ncc.HienThiNCC();
                LamMoi();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtDienThoai.Text, @"^\d{9,11}$"))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!!", "Thông báo");
                txtDienThoai.Focus();
                return;
            }
            try
            {
                dto_ncc.MaNCC1 = txtMaNCC.Text.Trim();
                dto_ncc.TenNCC1 = txtTenNCC.Text.Trim();
                dto_ncc.Dt = txtDienThoai.Text.Trim();
                dto_ncc.Dc = txtDiaChi.Text.Trim();

                bus_ncc.SuaNCC(dto_ncc.MaNCC1, dto_ncc.TenNCC1, dto_ncc.Dt, dto_ncc.Dc);
                MessageBox.Show("Sửa thành công", "Thông báo");
                dgvNCC.DataSource = bus_ncc.HienThiNCC();
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
                dto_ncc.MaNCC1 = txtMaNCC.Text.Trim();

                bus_ncc.XoaNCC(dto_ncc.MaNCC1);
                MessageBox.Show("Xóa thành công", "Thông báo");
                dgvNCC.DataSource = bus_ncc.HienThiNCC();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            LamMoi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            try
            {
                txtMaNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
                txtDienThoai.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            }
            catch { }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNCC.DataSource = bus_ncc.TimKiemNCC(txtTimKiem.Text);
        }
    }
}


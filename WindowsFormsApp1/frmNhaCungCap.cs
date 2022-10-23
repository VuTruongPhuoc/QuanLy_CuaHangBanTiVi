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
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LamMoi();
            dgvNhaCungCap.DataSource = bus_ncc.HienThiNCC();
            MaNCC.Width = 200;
            TenNCC.Width = 200;
        }
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            try
            {
                txtMaNCC.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.TextLength == 0) { MessageBox.Show("Vui lòng nhập Mã NCC !", "Thông báo"); return; }
            else if (txtTenNCC.TextLength == 0) { MessageBox.Show("Vui lòng nhập Tên NCC !", "Thông báo"); return; }

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

                bus_ncc.ThemNCC(dto_ncc.MaNCC1, dto_ncc.TenNCC1);
                MessageBox.Show("Thêm thành công", "Thông báo");
                dgvNhaCungCap.DataSource = bus_ncc.HienThiNCC();
                LamMoi();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dto_ncc.MaNCC1 = txtMaNCC.Text.Trim();
                dto_ncc.TenNCC1 = txtTenNCC.Text.Trim();

                bus_ncc.SuaNCC(dto_ncc.MaNCC1, dto_ncc.TenNCC1);
                MessageBox.Show("Sửa thành công", "Thông báo");
                dgvNhaCungCap.DataSource = bus_ncc.HienThiNCC();
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
                dgvNhaCungCap.DataSource = bus_ncc.HienThiNCC();
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = bus_ncc.TimKiemNCC(txtTimKiem.Text);
        }

        
    }
}


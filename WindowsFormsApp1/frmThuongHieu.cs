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
    public partial class frmThuongHieu : Form
    {
        BUS_ThuongHieu bus_th = new BUS_ThuongHieu();
        DTO_ThuongHieu dto_th = new DTO_ThuongHieu();
        public frmThuongHieu()
        {
            InitializeComponent();
        }
        private void LamMoi()
        {
            txtMaTH.Text = "";
            txtTenTH.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void frmThuongHieu_Load(object sender, EventArgs e)
        {
            LamMoi();
            dgvTH.DataSource = bus_th.HienThiTH();
        }

        private void dgvTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTH.Text = dgvTH.CurrentRow.Cells["MaTH"].Value.ToString();
            txtTenTH.Text = dgvTH.CurrentRow.Cells["TenTH"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaTH.TextLength == 0) { MessageBox.Show("Vui lòng nhập Mã TH !", "Thông báo"); return; }
            else if (txtTenTH.TextLength == 0) { MessageBox.Show("Vui lòng nhập Tên TH !", "Thông báo"); return; }
            if (bus_th.KiemTraTrungMaTH(txtMaTH.Text))
            {
                MessageBox.Show("Mã Thương Hiệu đã tồn tại , vui lòng nhập lại!!", "Thông báo");
                txtMaTH.Focus();
                return;
            }
            try
            {
                dto_th.Math = txtMaTH.Text.ToString().Trim();
                dto_th.Tenth = txtTenTH.Text.ToString().Trim();

                bus_th.ThemTH(dto_th.Math,dto_th.Tenth);
                MessageBox.Show("Thêm thành công", "Thông báo");
                dgvTH.DataSource = bus_th.HienThiTH();
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
                dto_th.Math = txtMaTH.Text.ToString().Trim();
                dto_th.Tenth = txtTenTH.Text.ToString().Trim();

                bus_th.SuaTH(dto_th.Math, dto_th.Tenth);
                MessageBox.Show("Sửa thành công", "Thông báo");
                dgvTH.DataSource = bus_th.HienThiTH();
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
                dto_th.Math = txtMaTH.Text.ToString().Trim();

                bus_th.XoaTH(dto_th.Math);
                MessageBox.Show("Xóa thành công", "Thông báo");
                dgvTH.DataSource = bus_th.HienThiTH();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvTH.DataSource = bus_th.TimKiemTH(txtTimKiem.Text.ToString());
        }

        private void txtMaTH_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}

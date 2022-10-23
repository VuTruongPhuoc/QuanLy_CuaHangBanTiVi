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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if (!frmDangNhap.isAdmin)
            {
                nhânViênToolStripMenuItem.Enabled = false;
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            frmTaiKhoan.MdiParent = this;
            frmTaiKhoan.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Form frm = new frmDangNhap();
                frmDangNhap.taikhoan = null;
                frmDangNhap.matkhau = null;
                this.Close();
                frm.Show();
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.MdiParent = this;
            frmSanPham.Show();
            frmSanPham.Dock = DockStyle.Fill;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.MdiParent = this;
            frmKhachHang.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.MdiParent = this;
            frmNhanVien.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            frmNhaCungCap.MdiParent = this;
            frmNhaCungCap.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

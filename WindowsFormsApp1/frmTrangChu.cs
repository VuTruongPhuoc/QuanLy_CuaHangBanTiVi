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
        private bool CheckExitsForm(string name)
        {
            bool check = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    f.Activate();
                    break;
                }
            }
        }
        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmTaiKhoan"))
            {
                frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
                frmTaiKhoan.MdiParent = this;
                frmTaiKhoan.Show();
            }
            else
            {
                ActiveChildForm("frmTaiKhoan");
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            Form frm = new frmDangNhap();
            frmDangNhap.taikhoan = null;
            frmDangNhap.matkhau = null;
            this.Close();
            frm.Show();
            //}
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckExitsForm("frmSanPham"))
            {
                frmSanPham frmSanPham = new frmSanPham();
                frmSanPham.MdiParent = this;
                frmSanPham.Show();
                frmSanPham.Dock = DockStyle.Fill;
            }
            else
            {
                ActiveChildForm("frmSanPham");
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckExitsForm("frmKhachHang"))
            {
                frmKhachHang frmKhachHang = new frmKhachHang();
                frmKhachHang.MdiParent = this;
                frmKhachHang.Show();
            }
            else
            {
                ActiveChildForm("frmKhachHang");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckExitsForm("frmNhanVien"))
            {
                frmNhanVien frmNhanVien = new frmNhanVien();
                frmNhanVien.MdiParent = this;
                frmNhanVien.Show();
            }
            else
            {
                ActiveChildForm("frmNhanVien");
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckExitsForm("frmNhaCungCap"))
            {
                frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
                frmNhaCungCap.MdiParent = this;
                frmNhaCungCap.Show();
            }
            else
            {
                ActiveChildForm("frmNhaCungCap");
            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmDonHang"))
            {
                frmDonHang frmDonHang = new frmDonHang();
                frmDonHang.MdiParent = this;
                frmDonHang.Show();
            }
            else
            {
                ActiveChildForm("frmDonHang");
            }
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmDonNhap"))
            {
                frmDonNhap frmDonNhap = new frmDonNhap();
                frmDonNhap.MdiParent = this;
                frmDonNhap.Show();
            }
            else
            {
                ActiveChildForm("frmDonNhap");
            }
        }

        private void hàngTồnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmHangTon"))
            {
                frmHangTon frmHangTon = new frmHangTon();
                frmHangTon.MdiParent = this;
                frmHangTon.Show();
            }
            else
            {
                ActiveChildForm("frmHangTon");
            }
        }
    }
}

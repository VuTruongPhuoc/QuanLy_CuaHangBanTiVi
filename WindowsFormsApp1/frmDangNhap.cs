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

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {
        BUS.BUS_DangNhap bus_dn = new BUS_DangNhap();
        public static bool isAdmin;
        public static string taikhoan;
        public static string matkhau;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void chkbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbHienThiMK.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!bus_dn.Check_Login(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!!", "Thông báo");
                return;
            }
            if (!bus_dn.IsAdmin(txtTaiKhoan.Text, txtMatKhau.Text))
                isAdmin = false;
            else isAdmin = true;

            taikhoan = txtTaiKhoan.Text;
            matkhau = txtMatKhau.Text;
            frmTrangChu frmTrangChu = new frmTrangChu();
            this.Hide();
            frmTrangChu.Show();
            txtTaiKhoan.Focus();
        }
    }
}

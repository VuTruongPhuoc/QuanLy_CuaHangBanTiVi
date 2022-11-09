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
    public partial class frmDonNhap : Form
    {
        public static string sohdn;
        BUS.BUS_DonNhap bus_nh = new BUS_DonNhap();
        public frmDonNhap()
        {
            InitializeComponent();
        }
        public void frmNhapHang_Load(object sender, EventArgs e)
        {
            dgvNhapHang.DataSource = bus_nh.HienThiDonNhap();
        }
        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNhapHang.DataSource = bus_nh.TimKiemDonNhap(txtTimKiem.Text);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap frmHoaDonNhap = new frmHoaDonNhap();
            frmHoaDonNhap.Show();
        }

        private void dgvNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sohdn = dgvNhapHang.CurrentRow.Cells["SoHDN"].Value.ToString().Trim();
            frmCTHDN frmCTHDN = new frmCTHDN();
            frmCTHDN.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvNhapHang.DataSource = bus_nh.HienThiDonNhap();
        }
    }
}

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
    public partial class frmDonHang : Form
    {
        public static string sohdb;
        BUS.BUS_DonHang bus_dh = new BUS_DonHang();
        BUS.BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS.BUS_HoaDonBan bus_hd = new BUS_HoaDonBan();
        Resources.CommonFunction comm = new Resources.CommonFunction();
        public frmDonHang()
        {
            InitializeComponent();
        }

        public void frmDonHang_Load(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = bus_dh.HienThiDonHang();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = bus_dh.TimKiemDonHang(txtTimKiem.Text);           
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHoaDonBan = new frmHoaDonBan();
            frmHoaDonBan.Show();
        }

        private void gunadgvDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sohdb = dgvDonHang.CurrentRow.Cells["SoHDB"].Value.ToString().Trim();
            frmCTHD frmCTHD = new frmCTHD();
            frmCTHD.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = bus_dh.HienThiDonHang();
        }
    }
}

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
            comm.FillCombo(bus_kh.HienThiKhachHang(), cboMaKH, "TenKH", "MaKH");
            dgvDonHang.DataSource = bus_dh.HienThiDonHang();
        }

        private void gunadgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoHDB.Text = dgvDonHang.CurrentRow.Cells["SoHDB"].Value.ToString();
            lbNhanVien.Text = dgvDonHang.CurrentRow.Cells["MaNV"].Value.ToString();
            cboMaKH.SelectedValue = dgvDonHang.CurrentRow.Cells["MaKH"].Value.ToString();       
            gunadtpNgayLap.Value = (DateTime)dgvDonHang.CurrentRow.Cells["NgayLap"].Value;
            txtThanhTien.Text = dgvDonHang.CurrentRow.Cells["ThanhTien"].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = bus_dh.TimKiemDonHang(txtTimKiem.Text);           
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHoaDon = new frmHoaDonBan();
            frmHoaDon.Show();
        }

        private void gunadgvDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sohdb = dgvDonHang.CurrentRow.Cells["SoHDB"].Value.ToString().Trim();
            frmCTHD frmCTHD = new frmCTHD();
            this.Hide();
            frmCTHD.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = bus_dh.HienThiDonHang();
        }
    }
}

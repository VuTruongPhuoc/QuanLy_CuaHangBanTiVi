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
        BUS.BUS_HoaDon bus_hd = new BUS_HoaDon();
        Resources.CommonFunction comm = new Resources.CommonFunction();
        public frmDonHang()
        {
            InitializeComponent();
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            gunadtpNgayLap.Format = DateTimePickerFormat.Custom;
            //gunadtpNgayLap.CustomFormat = "dd/mm/yyyy";
            comm.FillCombo(bus_kh.HienThiKhachHang(), cboMaKH, "TenKH", "MaKH");
            gunadgvDonHang.DataSource = bus_dh.HienThiDonHang();
        }

        private void gunadgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoHDB.Text = gunadgvDonHang.CurrentRow.Cells["SoHDB"].Value.ToString();
            lbNhanVien.Text = gunadgvDonHang.CurrentRow.Cells["MaNV"].Value.ToString();
            cboMaKH.SelectedValue = gunadgvDonHang.CurrentRow.Cells["MaKH"].Value.ToString();       
            gunadtpNgayLap.Value = (DateTime)gunadgvDonHang.CurrentRow.Cells["NgayLap"].Value;
            txtThanhTien.Text = gunadgvDonHang.CurrentRow.Cells["ThanhTien"].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            gunadgvDonHang.DataSource = bus_dh.TimKiemDonHang(txtTimKiem.Text);           
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.Show();
        }

        private void gunadgvDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sohdb = gunadgvDonHang.CurrentRow.Cells["SoHDB"].Value.ToString().Trim();
            frmCTHD frmCTHD = new frmCTHD();
            frmCTHD.Show();
        }
    }
}

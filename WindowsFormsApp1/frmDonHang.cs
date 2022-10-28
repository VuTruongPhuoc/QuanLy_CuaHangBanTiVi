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
        BUS.BUS_DonHang bus_dh = new BUS_DonHang();
        BUS.BUS_KhachHang bus_kh = new BUS_KhachHang(); 
        Resources.CommonFunction comm = new Resources.CommonFunction();
        public frmDonHang()
        {
            InitializeComponent();
        }
        public void AddCombobox()
        {
            cboTimKiem.Items.Add("Số HDB");
            cboTimKiem.Items.Add("Mã KH");
            cboTimKiem.Items.Add("Ngày");
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            AddCombobox();
            gunadtpNgayLap.Format = DateTimePickerFormat.Custom;
            gunadtpNgayLap.CustomFormat = "dd/mm/yyyy";
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
            DataTable dt = new DataTable();
            dt = bus_dh.HienThiDonHang();
            if(cboTimKiem.SelectedIndex == 2)
            {
                DateTime.Parse(dt.Rows[0]["NgayLap"].ToString().Trim());
                gunadgvDonHang.DataSource = bus_dh.TimKiemDonHang(txtTimKiem.Text);
            }
            
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.Show();
        }
    }
}

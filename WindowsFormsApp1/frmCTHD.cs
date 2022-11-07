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
    public partial class frmCTHD : Form
    {
        BUS_HoaDonBan bus_hd = new BUS_HoaDonBan();
        BUS_CTHD bus_ct = new BUS_CTHD();
        public frmCTHD()
        {
            InitializeComponent();
        }
        private void frmCTHD_Load(object sender, EventArgs e)
        {
            txtSoHDB.Text = frmDonHang.sohdb;
            DataTable dt = new DataTable();
            dt = bus_ct.HienThiTT(txtSoHDB.Text);          
            dgvCTHD.DataSource = bus_hd.HienThiCTHoaDon(txtSoHDB.Text);
            try
            {
                txtNV.Text = dt.Rows[0]["TTNV"].ToString();
                txtKH.Text = dt.Rows[0]["TTKH"].ToString();
                dtpThoiGian.Value = (DateTime)dt.Rows[0]["NgayLap"];
                txtKM.Text = dt.Rows[0]["Khuyenmai"].ToString();
            }
            catch { }
            

            DataTable dt1 = new DataTable();
            dt1 = bus_hd.HienThiThanhTien(txtSoHDB.Text);
            lbThanhTien.Text = dt1.Rows[0]["ThanhTien"].ToString();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bus_ct.XoaHD(txtSoHDB.Text);
                MessageBox.Show("Xóa hóa đơn thành công");
            }
            this.Close();
        }
    }
}

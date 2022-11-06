using BUS;
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
    public partial class frmCTHDN : Form
    {
        BUS_HoaDonNhap bus_hdn = new BUS_HoaDonNhap();
        BUS_CTHDN bus_ctn = new BUS_CTHDN();
        public frmCTHDN()
        {
            InitializeComponent();
        }

        private void frmCTHDN_Load(object sender, EventArgs e)
        {
            txtSoHDN.Text = frmDonNhap.sohdn;
            DataTable dt = new DataTable();
            dt = bus_ctn.HienThiTT(txtSoHDN.Text);
            dgvCTHDN.DataSource = bus_hdn.HienThiCTHDN(txtSoHDN.Text);
            try
            {
                txtNV.Text = dt.Rows[0]["TTNV"].ToString();
                txtNCC.Text = dt.Rows[0]["TTNCC"].ToString();
                dtpThoiGian.Value = (DateTime)dt.Rows[0]["NgayNhap"];
                txtKM.Text = dt.Rows[0]["Khuyenmai"].ToString();
            }
            catch { }


            DataTable dt1 = new DataTable();
            dt1 = bus_hdn.HienThiThanhTien(txtSoHDN.Text);
            lbThanhTien.Text = dt1.Rows[0]["ThanhTien"].ToString();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {         
            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bus_ctn.XoaHDN(txtSoHDN.Text);
                MessageBox.Show("Xóa hóa đơn thành công");
            }
            this.Close();
        }
    }
}

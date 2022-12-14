using BUS;
using DTO;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class frmHoaDonNhap : Form
    {
        BUS.BUS_HoaDonNhap bus_hdn = new BUS_HoaDonNhap();
        BUS_SanPham bus_sp = new BUS_SanPham();
        BUS_DonNhap bus_nh = new BUS_DonNhap();
        BUS_CTHDN bus_ctn = new BUS_CTHDN();
        DTO_HoaDonNhap dto_hdn = new DTO_HoaDonNhap();
        DTO_DonNhap dto_nh = new DTO_DonNhap();
        Resources.CommonFunction comm = new Resources.CommonFunction();
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bus_hdn.HienThiNV(frmDangNhap.taikhoan);
            txtNV.Text = dt.Rows[0]["MaNV"].ToString().Trim() + " | " + dt.Rows[0]["TenNV"].ToString().Trim();
            comm.FillCombo(bus_hdn.HienThiNCC(), cboNCC, "TTNCC", "MaNCC");
            dtpThoiGian.Value = DateTime.Now;
            try
            {
                Random rd = new Random();
                txtSoHD.Text = "HDN" + rd.Next(1, 10000).ToString();
                if (bus_hdn.KiemTraTrungMaHDN(txtSoHD.Text.ToString().Trim()))
                {
                    frmHoaDonNhap_Load(sender, e);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Mã hóa đơn đã bị trùng! Vui lòng tạo mới");
            }
            bus_nh.ThemDonNhap(txtSoHD.Text.Trim(), null, dt.Rows[0]["MaNV"].ToString(), dtpThoiGian.Value.ToString(), 0);
            Lammoi();
        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSP.SelectedIndex != -1)
            {
                String str = cboSP.SelectedItem.ToString();
                string[] a = str.Split('|');
                string TenSP = a[1].Trim();
                DataTable dt = new DataTable();
                dt = bus_hdn.HienThiSP(TenSP);
                txtDonGia.Text = dt.Rows[0]["DonGiaNhap"].ToString().Trim();
            }
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            double sl, dg, gg;
            try
            {
                if (numSoLuong.Value == 0)
                    sl = 0;
                else
                    sl = Double.Parse(numSoLuong.Value.ToString());
                if (txtKhuyenMai.Text == "0" || txtKhuyenMai.Text == "")
                    gg = 0;
                else
                    gg = Double.Parse(txtKhuyenMai.Text);
                if (txtDonGia.Text == "")
                    dg = 0;
                else
                    dg = Double.Parse(txtDonGia.Text);
                txtThanhTien.Text = ((sl * dg) - sl * dg * gg / 100).ToString();
            }
            catch { }
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, gg;
            try
            {
                if (numSoLuong.Value == 0)
                    sl = 0;
                else
                    sl = Double.Parse(numSoLuong.Value.ToString());
                if (txtKhuyenMai.Text == "0" || txtKhuyenMai.Text == "")
                    gg = 0;
                else
                    gg = Double.Parse(txtKhuyenMai.Text);
                if (txtDonGia.Text == "")
                    dg = 0;
                else
                    dg = Double.Parse(txtDonGia.Text);
                txtThanhTien.Text = ((sl * dg) - sl * dg * gg / 100).ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSP.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo"); return; }
            if (numSoLuong.Value == 0) { MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo"); return; }
            String str = cboSP.SelectedItem.ToString();
            string[] a = str.Split('|');
            string TenSP = a[1].Trim();
            DataTable dt = new DataTable();
            dt = bus_hdn.HienThiSP(TenSP);
            try
            {
                dto_hdn.Sohdn = txtSoHD.Text.ToString();
                dto_hdn.Masp = dt.Rows[0]["MaSP"].ToString().Trim();
                dto_hdn.Sl = Int16.Parse(numSoLuong.Value.ToString().Trim());
                dto_hdn.Km = txtKhuyenMai.Text.ToString();

                bus_hdn.ThemCTHDN(dto_hdn.Sohdn, dto_hdn.Masp, dto_hdn.Sl, dto_hdn.Km);
                MessageBox.Show("Thêm thành công!");
                dgvHoaDonNhap.DataSource = bus_hdn.HienThiCTHDN(dto_hdn.Sohdn);

            }
            catch { MessageBox.Show("Vui lòng chọn sản phẩm khác!"); }
            DataTable dt3 = new DataTable();
            dt3 = bus_hdn.HienThiThanhTien(txtSoHD.Text);
            lbThanhTien.Text = dt3.Rows[0]["ThanhTien"].ToString().Trim();
            cboSP.Items.Clear();
            Lammoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonNhap.Rows.Count <= 1) { MessageBox.Show("Không có chi tiết sản phẩm để xóa!", "Thông báo"); return; }
            if (dgvHoaDonNhap.CurrentRow.Cells["MaSP"].Value.ToString() == "") { MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo"); return; }
            try
            {
                dto_hdn.Sohdn = txtSoHD.Text.ToString().Trim();
                dto_hdn.Masp = dgvHoaDonNhap.CurrentRow.Cells["MaSP"].Value.ToString();

                bus_hdn.XoaSP(dto_hdn.Sohdn, dto_hdn.Masp);
                MessageBox.Show("Xóa thành công!");
                dgvHoaDonNhap.DataSource = bus_hdn.HienThiCTHDN(dto_hdn.Sohdn);
            }
            catch { }
            DataTable dt = new DataTable();
            dt = bus_hdn.HienThiThanhTien(txtSoHD.Text);
            lbThanhTien.Text = dt.Rows[0]["ThanhTien"].ToString().Trim();
            cboSP.Items.Clear();
            Lammoi();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonNhap.Rows.Count <= 1) { MessageBox.Show("Vui lòng thêm chi tiết sản phẩm!", "Thông báo"); return; }
            String str = cboNCC.SelectedValue.ToString();
            string[] a = str.Split('|');
            string mancc = a[0].ToString();
            DataTable dt = new DataTable();
            dt = bus_nh.HienThiMaNV(frmDangNhap.taikhoan);
            try
            {
                dto_nh.Sohdn = txtSoHD.Text.ToString().Trim();
                dto_nh.Mancc = mancc;
                dto_nh.Manv = dt.Rows[0]["MaNV"].ToString().Trim();
                dto_nh.Thanhtien = double.Parse(lbThanhTien.Text.ToString().Trim());
            }
            catch { }
            bus_nh.SuaDonNhap(dto_nh.Sohdn, dto_nh.Mancc, dto_nh.Manv, dto_nh.Thanhtien);
            //xuat file ra excel
            if (MessageBox.Show("Bạn có muốn in hóa đơn nhập không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Export Excel";
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportExcel(saveFileDialog.FileName);
                        MessageBox.Show("Xuất file thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xuất file\r" + ex.Message);
                    }
                }
            }
            MessageBox.Show("Thanh toán thành công!!");
            frmDonNhap frmDonNhap = new frmDonNhap();
            this.Close();
        }
        private void Lammoi()
        {
            DataTable dt = new DataTable();
            dt = bus_sp.HienThiSanPham();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboSP.Items.Add(dt.Rows[i][0].ToString() + " | " + dt.Rows[i][1].ToString());
            }
            cboSP.SelectedIndex = -1;
            txtDonGia.Text = "";
            numSoLuong.Value = 0;
            txtKhuyenMai.Text = "0";
            txtThanhTien.Text = "";
        }
        private void btnHuyDonNhap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bus_ctn.XoaHDN(txtSoHD.Text);
                MessageBox.Show("Bạn đã hủy đơn hàng thành công");
                this.Close();
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Application.Workbooks.Add(Type.Missing);
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; //Đưa con trỏ vào ô A1
            //Tiêu đề
            tenTruong.Font.Size = 10; //Đặt cỡ chữ là 10
            tenTruong.Font.Name = "Times new roman"; //Chọn font Times new roman
            tenTruong.Font.Bold = true; //Định dạng kiểu font chữ là in đậm
            tenTruong.Font.Color = Color.Blue;
            //Set cac thong tin co ban cua hoa don
            tenTruong.Range["C2:E2"].MergeCells = true;
            tenTruong.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP HÀNG";
            tenTruong.Range["C2:E2"].Font.Size = 15;
            tenTruong.Range["C2:E2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            DataTable dt = bus_hdn.HienThiThongTinExport(txtSoHD.Text.ToString());


            tenTruong.Range["B3:C8"].Font.Size = 12;
            tenTruong.Range["C4:E4"].MergeCells = true;
            tenTruong.Range["C4:E4"].Value = "Ngày " + dtpThoiGian.Value.Day.ToString() + " Tháng " + dtpThoiGian.Value.Month.ToString() + " Năm " + dtpThoiGian.Value.Year.ToString();
            tenTruong.Range["B5:B5"].Value = "Mã hóa đơn:";
            tenTruong.Range["C5:E5"].MergeCells = true;
            tenTruong.Range["C5:E5"].Value = dt.Rows[0][0].ToString();
            tenTruong.Range["B6:B6"].Value = "Nhà cung cấp:";
            tenTruong.Range["C6:E6"].MergeCells = true;
            tenTruong.Range["C6:E6"].Value = dt.Rows[0][1].ToString();
            tenTruong.Range["B7:B7"].Value = "Địa chỉ:";
            tenTruong.Range["C7:E7"].MergeCells = true;
            tenTruong.Range["C7:E7"].Value = dt.Rows[0][2].ToString();
            tenTruong.Range["B8:B8"].Value = "Điện thoại:";
            tenTruong.Range["C8:E8"].MergeCells = true;
            tenTruong.Range["C8:E8"].Value = dt.Rows[0][3].ToString();
            //in dữ liệu từ datagraview
            int i, j;
            for (i = 0; i < dgvHoaDonNhap.Columns.Count; i++)
            {
                exApp.Cells[10, 1] = "STT";
                exApp.Cells[10, i + 2] = dgvHoaDonNhap.Columns[i].HeaderText;
            }
            for (i = 0; i < dgvHoaDonNhap.Rows.Count - 1; i++)
            {
                for (j = 0; j < dgvHoaDonNhap.Columns.Count ; j++)
                {
                    exApp.Cells[i + 11, 1] = i + 1;
                    exApp.Cells[i + 11, j + 2] = dgvHoaDonNhap.Rows[i].Cells[j].Value;
                }
            }
            tenTruong.Range["A9:F9"].Font.Bold = true;
            DataTable dt2 = bus_hdn.HienThiThanhTien(txtSoHD.Text.ToString());
            tenTruong = exSheet.Cells[5][i + 13];
            tenTruong.Font.Bold = true;
            tenTruong.Value2 = "Tổng tiền :";
            tenTruong = exSheet.Cells[6][i + 13];
            tenTruong.Font.Bold = true;
            tenTruong.Value2 = dt2.Rows[0][0].ToString();
            //set save file 
            exApp.Columns.ColumnWidth = 14;
            exApp.ActiveWorkbook.SaveCopyAs(path);
            exApp.ActiveWorkbook.Saved = true;
        }
    }
}

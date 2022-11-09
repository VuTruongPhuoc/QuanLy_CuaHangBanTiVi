using BUS;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;

namespace WindowsFormsApp1
{
    public partial class frmHoaDonBan : Form
    {
        BUS_HoaDonBan bus_hd = new BUS_HoaDonBan();
        frmDangNhap frmDangNhap = new frmDangNhap();
        Resources.CommonFunction comm = new Resources.CommonFunction();
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_SanPham bus_sp = new BUS_SanPham();
        DTO_HoaDonBan dto_hd = new DTO_HoaDonBan();
        BUS_DonHang bus_dh = new BUS_DonHang();
        DTO_DonHang dto_dh = new DTO_DonHang();
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bus_hd.HienThiNV(frmDangNhap.taikhoan);
            txtNV.Text = dt.Rows[0]["MaNV"].ToString().Trim() + " | " + dt.Rows[0]["TenNV"].ToString().Trim();
            comm.FillCombo(bus_hd.HienThiKH(), cboKH, "TTKH", "MaKH");
            dtpThoiGian.Value = DateTime.Now;
            try
            {
                Random rd = new Random();
                txtSoHD.Text = "HDB" + rd.Next(1, 10000).ToString();
                if (bus_hd.KiemTraTrungMaHDB(txtSoHD.Text.ToString().Trim()))
                {
                    frmHoaDonBan_Load(sender, e);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Mã hóa đơn đã bị trùng! Vui lòng tạo mới");
            }
            

            DataTable dt2 = new DataTable();
            dt2 = bus_sp.HienThiSanPham();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cboSP.Items.Add(dt2.Rows[i][0].ToString() + " | " + dt2.Rows[i][1].ToString() + " | " + dt2.Rows[i][5].ToString());
            }
            bus_dh.ThemDonHang(txtSoHD.Text, null, null, dtpThoiGian.Value.ToString(), 0);
            Lammoi();
        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(cboSP.SelectedIndex != -1)
             {
                String str = cboSP.SelectedItem.ToString();
                string[] a = str.Split('|');
                string TenSP = a[1].Trim();
                DataTable dt = new DataTable();
                dt = bus_hd.HienThiSP(TenSP);
                txtDonGia.Text = dt.Rows[0]["DonGiaBan"].ToString().Trim();
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
            dt = bus_hd.HienThiSP(TenSP);
            try
            {
                dto_hd.Sohdb = txtSoHD.Text.ToString();
                dto_hd.Masp = dt.Rows[0]["MaSP"].ToString().Trim();
                dto_hd.Slban = Int16.Parse(numSoLuong.Value.ToString().Trim());
                dto_hd.Km = txtKhuyenMai.Text.ToString();

                bus_hd.ThemCTHD(dto_hd.Sohdb, dto_hd.Masp, dto_hd.Slban, dto_hd.Km);
                MessageBox.Show("Thêm thành công!");
                gunadgvHoaDon.DataSource = bus_hd.HienThiCTHoaDon(dto_hd.Sohdb);

            }
            catch { MessageBox.Show("Vui lòng chọn sản phẩm khác"); }
            DataTable dt3 = new DataTable();
            dt3 = bus_hd.HienThiThanhTien(txtSoHD.Text);
            lbThanhTien.Text = dt3.Rows[0]["ThanhTien"].ToString().Trim();
            Lammoi();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gunadgvHoaDon.CurrentRow.Cells["MaSP"].Value.ToString() == "") { MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo"); return; }
            try
            {
                dto_hd.Sohdb = txtSoHD.Text.ToString().Trim();
                dto_hd.Masp = gunadgvHoaDon.CurrentRow.Cells["MaSP"].Value.ToString(); ;

                bus_hd.XoaSP(dto_hd.Sohdb, dto_hd.Masp);
                gunadgvHoaDon.DataSource = bus_hd.HienThiCTHoaDon(dto_hd.Sohdb);
            }
            catch { MessageBox.Show("Vui lòng chọn sản phẩm để xóa"); }      
            DataTable dt = new DataTable();
            MessageBox.Show("Xóa thành công!");
            dt = bus_hd.HienThiThanhTien(txtSoHD.Text);
            lbThanhTien.Text = dt.Rows[0]["ThanhTien"].ToString().Trim();
            Lammoi();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            String str = cboKH.SelectedValue.ToString();
            string[] a = str.Split('|');
            string makh = a[0].ToString();
            DataTable dt = new DataTable();
            dt = bus_dh.HienThiMaNV(frmDangNhap.taikhoan);
            try
            {
                dto_dh.Sohdb1 = txtSoHD.Text.ToString().Trim();
                dto_dh.Manv = dt.Rows[0]["MaNV"].ToString().Trim();
                dto_dh.Makh = makh;
                dto_dh.Thanhtien = double.Parse(lbThanhTien.Text.ToString().Trim());
            }
            catch { }
            bus_dh.SuaDonHang(dto_dh.Sohdb1, dto_dh.Manv, dto_dh.Makh,dto_dh.Thanhtien);
            //xuat file ra excel
            if(MessageBox.Show("Bạn có muốn in hóa đơn không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Export Excel";
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportExcel(saveFileDialog.FileName);
                        MessageBox.Show("Xuất file thành công");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi xuất file\r" +ex.Message);
                    }
                }
            }
            MessageBox.Show("Thanh toán thành công!!");
            frmDonHang frmDonHang = new frmDonHang();
            this.Close();
        }
        private void Lammoi()
        {
            cboSP.SelectedIndex = -1;
            txtDonGia.Text = "";
            numSoLuong.Value = 0;
            txtKhuyenMai.Text = "0";
            txtThanhTien.Text = "";
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
            tenTruong.Range["C2:E2"].Value = "HÓA ĐƠN BÁN HÀNG";
            tenTruong.Range["C2:E2"].Font.Size = 15;
            tenTruong.Range["C2:E2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; 
            DataTable dt = bus_hd.HienThiThongTinExport(txtSoHD.Text.ToString());
            tenTruong.Range["B4:C7"].Font.Size = 12;
            tenTruong.Range["B4:B4"].Value = "Mã hóa đơn:";
            tenTruong.Range["C4:E4"].MergeCells = true;
            tenTruong.Range["C4:E4"].Value = dt.Rows[0][0].ToString();
            tenTruong.Range["B5:B5"].Value = "Khách hàng:";
            tenTruong.Range["C5:E5"].MergeCells = true;
            tenTruong.Range["C5:E5"].Value = dt.Rows[0][1].ToString();
            tenTruong.Range["B6:B6"].Value = "Địa chỉ:";
            tenTruong.Range["C6:E6"].MergeCells = true;
            tenTruong.Range["C6:E6"].Value = dt.Rows[0][2].ToString();
            tenTruong.Range["B7:B7"].Value = "Điện thoại:";
            tenTruong.Range["C7:E7"].MergeCells = true;
            tenTruong.Range["C7:E7"].Value = dt.Rows[0][3].ToString();
            //in dữ liệu từ datagraview
            int i, j;
            for (i = 0; i < gunadgvHoaDon.Columns.Count; i++)
            {
                exApp.Cells[9, 1] = "STT";
                exApp.Cells[9, i + 2] = gunadgvHoaDon.Columns[i].HeaderText;
            }
            for(i = 0; i < gunadgvHoaDon.Rows.Count -1; i++)
            {
                for (j = 0; j < gunadgvHoaDon.Columns.Count; j++)
                {
                    exApp.Cells[i + 10, 1] = i + 1;
                    exApp.Cells[i+10, j + 2] = gunadgvHoaDon.Rows[i].Cells[j].Value;
                }
            }
            tenTruong.Range["A9:E9"].Font.Bold = true;
            DataTable dt2 = bus_hd.HienThiThanhTien(txtSoHD.Text.ToString());
            tenTruong = exSheet.Cells[5][i + 12];
            tenTruong.Font.Bold = true;
            tenTruong.Value2 = "Tổng tiền";
            tenTruong = exSheet.Cells[6][i + 12];
            tenTruong.Font.Bold = true;
            tenTruong.Value2 = dt2.Rows[0][0].ToString();

            //set save file 
            exApp.Columns.ColumnWidth = 14;
            exApp.ActiveWorkbook.SaveCopyAs(path);
            exApp.ActiveWorkbook.Saved = true;
        }   
    }
}

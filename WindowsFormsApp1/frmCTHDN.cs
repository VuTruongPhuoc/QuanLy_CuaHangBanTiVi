using BUS;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
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
            DataTable dt = bus_hdn.HienThiThongTinExport(txtSoHDN.Text.ToString());


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
            for (i = 0; i < dgvCTHDN.Columns.Count; i++)
            {
                exApp.Cells[10, 1] = "STT";
                exApp.Cells[10, i + 2] = dgvCTHDN.Columns[i].HeaderText;
            }
            for (i = 0; i < dgvCTHDN.Rows.Count - 1; i++)
            {
                for (j = 0; j < dgvCTHDN.Columns.Count; j++)
                {
                    exApp.Cells[i + 11, 1] = i + 1;
                    exApp.Cells[i + 11, j + 2] = dgvCTHDN.Rows[i].Cells[j].Value;
                }
            }
            tenTruong.Range["A9:F9"].Font.Bold = true;
            DataTable dt2 = bus_hdn.HienThiThanhTien(txtSoHDN.Text.ToString());
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

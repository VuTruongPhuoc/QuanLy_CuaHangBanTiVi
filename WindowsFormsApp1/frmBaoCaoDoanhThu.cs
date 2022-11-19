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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;

namespace WindowsFormsApp1
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        BUS_BaoCaoDoanhThu bus_bcdt = new BUS_BaoCaoDoanhThu();
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }
        public void AddComBoBox()
        {           
            cboThoiGian.Items.Add("Theo tháng");
            cboThoiGian.Items.Add("Theo năm");        
        }
        private void cboThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboThoiGian.SelectedIndex == 0)
            {
                dgvDoanhThu.DataSource = bus_bcdt.BaoCaoDoanhThuThang(Int16.Parse(cboThang.SelectedItem.ToString()), Int16.Parse(cboNam.SelectedItem.ToString()));
                DataTable dt = new DataTable();
                dt = bus_bcdt.TongDoanhThuThang(Int16.Parse(cboThang.SelectedItem.ToString()), Int16.Parse(cboNam.SelectedItem.ToString()));
                lbTienHang.Text = dt.Rows[0]["TongTienHang"].ToString().Trim();
                lbGiamGia.Text = dt.Rows[0]["TongKhuyenmai"].ToString().Trim();
                lbDoanhThu.Text = dt.Rows[0]["TongDoanhThu"].ToString().Trim();
            }else if(cboThoiGian.SelectedIndex == 1)
            {
                dgvDoanhThu.DataSource = bus_bcdt.BaoCaoDoanhThuNam(Int16.Parse(cboNam.SelectedItem.ToString()));
                DataTable dt = new DataTable();
                dt = bus_bcdt.TongDoanhThuNam(Int16.Parse(cboNam.SelectedItem.ToString()));
                lbTienHang.Text = dt.Rows[0]["TongTienHang"].ToString().Trim();
                lbGiamGia.Text = dt.Rows[0]["TongKhuyenmai"].ToString().Trim();
                lbDoanhThu.Text = dt.Rows[0]["TongDoanhThu"].ToString().Trim();
            }
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            for (int i = 2017; i < 2024; i++)
            {
                cboNam.Items.Add(i);
            }
            for (int i = 1; i < 13; i++)
            {
                cboThang.Items.Add(i);
            }
            AddComBoBox();
            cboThang.SelectedIndex = 10;
            cboNam.SelectedIndex = 5;
            dgvDoanhThu.DataSource = bus_bcdt.BaoCaoDoanhThuThang(Int16.Parse(cboThang.SelectedItem.ToString()), Int16.Parse(cboNam.SelectedItem.ToString()));
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
            tenTruong.Range["C2:E2"].Value = "Báo Cáo Doanh Thu";
            tenTruong.Range["C2:E2"].Font.Size = 15;
            tenTruong.Range["C2:E2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            tenTruong.Range["B4:C4"].Font.Size = 12;
            tenTruong.Range["B4:B4"].Value = "Thời gian:";
            tenTruong.Range["C4:E4"].MergeCells = true;
            if(cboThoiGian.SelectedIndex == 0)
            {
                tenTruong.Range["C4:E4"].Value = "Tháng " + cboThang.SelectedItem.ToString() + " Năm " + cboNam.SelectedItem.ToString();
            }else if(cboThoiGian.SelectedIndex == 1)
            {
                tenTruong.Range["C4:E4"].Value = "Năm " + cboNam.SelectedItem.ToString();
            }
            
            //in dữ liệu từ datagraview
            int i, j;
            for (i = 0; i < dgvDoanhThu.Columns.Count; i++)
            {
                exApp.Cells[6, 1] = "STT";
                exApp.Cells[6, i + 2] = dgvDoanhThu.Columns[i].HeaderText;
            }
            for (i = 0; i < dgvDoanhThu.Rows.Count - 1; i++)
            {
                for (j = 0; j < dgvDoanhThu.Columns.Count; j++)
                {
                    exApp.Cells[i + 7, 1] = i + 1;
                    exApp.Cells[i + 7, j + 2] = dgvDoanhThu.Rows[i].Cells[j].Value;
                }
            }
            tenTruong.Range["A6:F6"].Font.Bold = true;
            tenTruong.Range["D12:E14"].Font.Size = 12;
            tenTruong = exSheet.Cells[4][i + 9];
            tenTruong.Font.Bold = true;
            tenTruong.Value2 = "Tổng tiền hàng :";
            tenTruong.Range["D12:E12"].MergeCells = true;
            tenTruong = exSheet.Cells[6][i + 9];
            tenTruong.Font.Bold = true;
            tenTruong.Value2 = lbTienHang.Text.ToString() + "  VND";
            tenTruong.Range["F12:G12"].MergeCells = true;

            tenTruong = exSheet.Cells[4][i + 10];
            tenTruong.Font.Bold = true;           
            tenTruong.Value2 = "Tổng giảm giá :";
            tenTruong.Range["D13:E13"].MergeCells = true;
            tenTruong = exSheet.Cells[6][i + 10];
            tenTruong.Font.Bold = true;
            tenTruong.Value2 = lbGiamGia.Text.ToString() + "  VND";
            tenTruong.Range["F13:G13"].MergeCells = true;

            tenTruong = exSheet.Cells[4][i + 11];
            tenTruong.Font.Bold = true;           
            tenTruong.Value2 = "Tổng doanh thu :";
            tenTruong.Range["D14:E14"].MergeCells = true;
            tenTruong = exSheet.Cells[6][i + 11];
            tenTruong.Font.Bold = true;
            tenTruong.Value2 = lbDoanhThu.Text.ToString() + "  VND";
            tenTruong.Range["F14:G14"].MergeCells = true;


            //set save file 
            exApp.Columns.ColumnWidth = 14;
            exApp.ActiveWorkbook.SaveCopyAs(path);
            exApp.ActiveWorkbook.Saved = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn in báo cáo doanh thu không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
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
    }
}

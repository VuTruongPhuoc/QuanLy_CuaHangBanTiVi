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
using DTO;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;

namespace WindowsFormsApp1
{
    public partial class frmHangTon : Form
    {
        BUS_HangTon bus_ht = new BUS_HangTon();
        public frmHangTon()
        {
            InitializeComponent();
        }

        private void frmHangTon_Load(object sender, EventArgs e)
        {
            gunadgvHangTon.DataSource = bus_ht.HienThiHangTon();
        }

        private void txtHangTon_TextChanged(object sender, EventArgs e)
        {
            gunadgvHangTon.DataSource = bus_ht.TimKiemHangTon(txtHangTon.Text.ToString().Trim());
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn in hàng tồn không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
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
            tenTruong.Range["A2:C2"].MergeCells = true;
            tenTruong.Range["A2:C2"].Value = "Thống Kê Hàng Tồn";
            tenTruong.Range["A2:C2"].Font.Size = 15;
            tenTruong.Range["A2:C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;          
            //in dữ liệu từ datagraview
            int i, j;
            for (i = 0; i < gunadgvHangTon.Columns.Count; i++)
            {
                exApp.Cells[4, 1] = "STT";
                exApp.Cells[4, i + 2] = gunadgvHangTon.Columns[i].HeaderText;
            }
            for (i = 0; i < gunadgvHangTon.Rows.Count - 1; i++)
            {
                for (j = 0; j < gunadgvHangTon.Columns.Count; j++)
                {
                    exApp.Cells[i + 5, 1] = i + 1;
                    exApp.Cells[i + 5, j + 2] = gunadgvHangTon.Rows[i].Cells[j].Value;
                }
            }

            //set save file 
            exApp.Columns.ColumnWidth = 14;
            exApp.ActiveWorkbook.SaveCopyAs(path);
            exApp.ActiveWorkbook.Saved = true;
        }

        
    }
}

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
    public partial class frmDoanhThu : Form
    {
        BUS.BUS_DoanhThu bus_dt = new BUS_DoanhThu();
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        public void addcombobox()
        {
            cboDoanhThu.Items.Add("Theo năm");
        }
        private void cboDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDoanhThu.SelectedIndex == 0)
            {
                DataTable dt = new DataTable();
                dt = bus_dt.HienThiDoanhThu();
                ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                for (int i = 1; i < 12; i++)
                {
                    ChartDoanhThu.Series["DoanhThu"].Points.AddXY(i, dt.Rows[0]["Thang" + i]);
                }
            }
        }
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            addcombobox();
        }
    }
}

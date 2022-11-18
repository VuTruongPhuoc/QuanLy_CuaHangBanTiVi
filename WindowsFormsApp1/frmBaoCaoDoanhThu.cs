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
            cboThoiGian.Items.Add("Theo quý");
            cboThoiGian.Items.Add("Theo năm");        
        }
        private void cboThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboThoiGian.SelectedIndex == 0)
            {
                dgvDoanhThu.DataSource = bus_bcdt.BaoCaoDoanhThuThang(Int16.Parse(cboThang.SelectedItem.ToString()), Int16.Parse(cboNam.SelectedItem.ToString()));
            }else if(cboThoiGian.SelectedIndex == 1)
            {
                
            }
            else if(cboThoiGian.SelectedIndex == 2)
            {
                dgvDoanhThu.DataSource = bus_bcdt.BaoCaoDoanhThuNam(Int16.Parse(cboNam.SelectedItem.ToString()));
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
    }
}

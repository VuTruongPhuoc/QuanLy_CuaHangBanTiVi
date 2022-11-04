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
    }
}

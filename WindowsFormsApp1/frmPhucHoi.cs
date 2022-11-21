using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAO;

namespace WindowsFormsApp1
{
    public partial class frmPhucHoi : Form
    {
        DAO.DataAccess da = new DataAccess();
        public frmPhucHoi()
        {
            InitializeComponent();
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            string _vTruyVan = "";
            string _vTruyVan1 = "";
            string _vTruyVan2 = "";

            try
            {
                _vTruyVan = String.Format("ALTER DATABASE " + txtCsdl.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE ");
                da.DataChange(_vTruyVan);
                _vTruyVan1 = String.Format(" USE master RESTORE DATABASE " + txtCsdl.Text + " FROM DISK = '" + txtDuongdan.Text + "' WITH REPLACE");
                da.DataChange(_vTruyVan1);
                _vTruyVan2 = string.Format("ALTER DATABASE " + txtCsdl.Text + " SET MULTI_USER");
                da.DataChange(_vTruyVan2);
                MessageBox.Show("Phục Hổi Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCsdl.Text))
            {
                OpenFileDialog save = new OpenFileDialog();
                //' tao hoi dialog
                save.FileName = txtCsdl.Text;
                save.Filter = "File(*.bak)|*.bak";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtDuongdan.Text = save.FileName;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace WindowsFormsApp1
{
    public partial class frmSaoLuu : Form
    {
        DAO.DataAccess da = new DataAccess();
        public frmSaoLuu()
        {
            InitializeComponent();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuongdan.Text))
            {
                MessageBox.Show("Vui Lòng Chọn Đường Dẫn Để Lưu");
            }
            else
            {
                if (File.Exists(txtDuongdan.Text))
                {
                    File.Delete(txtDuongdan.Text);
                }
                try
                {
                    string saoluu = "Backup Database " + txtCsdl.Text + " to disk = '" + txtDuongdan.Text + "' ";
                    da.DataChange(saoluu);
                    MessageBox.Show("Sao Lưu Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể  Sao Lưu Dữ Liệu!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                SaveFileDialog save = new SaveFileDialog();
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

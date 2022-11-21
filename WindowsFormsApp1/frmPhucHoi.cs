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

namespace WindowsFormsApp1
{
    
    public partial class frmPhucHoi : Form
    {
        SqlConnection str = new SqlConnection("Data Source=DESKTOP-VEU6OUD\\SQLEXPRESS;database=BTL_CSharp;Integrated Security=True");

        public frmPhucHoi()
        {
            InitializeComponent();
        }

        private void Phuchoibtn_Click(object sender, EventArgs e)
        {
            string _vTruyVan = "";
            string _vTruyVan1 = "";
            string _vTruyVan2 = "";

            try
            {
                str.Open();
                _vTruyVan = String.Format("ALTER DATABASE " + txtCsdl.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE ");
                SqlCommand cmd1 = new SqlCommand(_vTruyVan, str);
                cmd1.ExecuteNonQuery();

                _vTruyVan1 = String.Format(" USE master RESTORE DATABASE " + txtCsdl.Text + " FROM DISK = '" + txtDuongdan.Text + "' WITH REPLACE");

                SqlCommand cmd2 = new SqlCommand(_vTruyVan1, str);
                cmd2.ExecuteNonQuery();

                _vTruyVan2 = string.Format("ALTER DATABASE " + txtCsdl.Text + " SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(_vTruyVan2, str);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Phục Hổi Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                str.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTTH4.mmm;
namespace BTTH4
{
    public partial class doimk : Form
    {
        public doimk()
        {
            InitializeComponent();
        }

        private void doimk_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMKCu, "");
            errorProvider1.SetError(txtNhapLaiMK, "");
            if (txtMKCu.Text.Length < 8 || !txtMKCu.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtMKCu, "Mat khau toi thieu 8 ki tu" + "in hoa, in thuong.");
                return;
            }
            if (txtMKCu.Text != txtNhapLaiMK.Text)
            {
                errorProvider1.SetError(txtNhapLaiMK, "Mat khau khong trung!");
                return;
            }
            Form1 f = (Form1)this.MdiParent;
            int count = XLBANG.Thuc_hien_lenh("update NHANVIEN set Password='" + txtMKCu.Text + "'where MaNV ='" + f.maNV + "'");
            if (count > 0)
            {
                MessageBox.Show("Cap nhat thanh cong!.");
            }
            else
                MessageBox.Show("Mat khau khong hop le");
        }
    }
}

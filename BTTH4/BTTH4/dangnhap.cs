using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTTH4.mmm;
namespace BTTH4
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        XL_NHANVIEN tblNhanVien;

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XL_NHANVIEN();
            var r = tblNhanVien.Select("Username='" + txtTen.Text + "' and Password ='" + txtMatkhau.Text + "'");
            if (r.Count() > 0)
            {
                Form1 f = (Form1)this.MdiParent;
                f.Text = "Quản lí Nhà Sách - Chào" + r[0]["TenNV"].ToString();
                f.maNV = r[0]["MaNV"].ToString();
                f.enableControl((int)r[0]["MaLTK"]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản và mật khẩu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMatkhau.Focus();
            }
        }

        private void txtMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangnhap.PerformClick();

            }
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

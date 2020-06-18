using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTTH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string maNV;
        doimk fDoiMK;
        public void enableControl(int maLTK)
        {
            switch (maLTK)
            { 
                case 1:
                    đăngNhậpToolStripMenuItem.Enabled = true;
                    //đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    nhânViênToolStripMenuItem.Enabled = true;
                    //chấmCôngToolStripMenuItem.Enabled = true;
                    sảnPhẩmToolStripMenuItem.Enabled = true;
                    đơnHàngToolStripMenuItem.Enabled = true;
                    thốngKêDoanhThuToolStripMenuItem.Enabled = true;
                    giớiThiệuToolStripMenuItem.Enabled = true;
                    break;
                case 2:
                    đăngNhậpToolStripMenuItem.Enabled = true;
                    //đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    nhânViênToolStripMenuItem.Enabled = false;
                    //chấmCôngToolStripMenuItem.Enabled = true;
                    sảnPhẩmToolStripMenuItem.Enabled = false;
                    đơnHàngToolStripMenuItem.Enabled = false;
                    thốngKêDoanhThuToolStripMenuItem.Enabled = false;
                    giớiThiệuToolStripMenuItem.Enabled = true;
                    break;
                case 3:
                    đăngNhậpToolStripMenuItem.Enabled = true;
                    //đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    nhânViênToolStripMenuItem.Enabled = false;
                    //chấmCôngToolStripMenuItem.Enabled = true;
                    sảnPhẩmToolStripMenuItem.Enabled = true;
                    đơnHàngToolStripMenuItem.Enabled = false;
                    thốngKêDoanhThuToolStripMenuItem.Enabled = false;
                    giớiThiệuToolStripMenuItem.Enabled = false;
                    break;
                default:
                    đăngNhậpToolStripMenuItem.Enabled = false;
                    //đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                    nhânViênToolStripMenuItem.Enabled = false;
                    //chấmCôngToolStripMenuItem.Enabled = true;
                    sảnPhẩmToolStripMenuItem.Enabled = false;
                    đơnHàngToolStripMenuItem.Enabled = false;
                    thốngKêDoanhThuToolStripMenuItem.Enabled = false;
                    giớiThiệuToolStripMenuItem.Enabled = false;
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            dangnhap f = new dangnhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Form1_Load(sender, e);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fDoiMK == null)
            {
                fDoiMK = new doimk();
                fDoiMK.MdiParent = this;
                fDoiMK.WindowState = FormWindowState.Maximized;
                fDoiMK.Show();
            }
            else
            {
                fDoiMK.Activate();
                fDoiMK.Show();
            }
        }
    }
}

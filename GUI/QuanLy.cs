using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLy : UserControl
    {
        public QuanLy()
        {
            InitializeComponent();
        }

     

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanLyNhanVien1.BringToFront();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanLySanPham1.BringToFront();
        }

      

        private void QuanLy_Load(object sender, EventArgs e)
        {
            quanLyNhanVien1.BringToFront();
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanLyBan1.BringToFront();
        }

        private void quảnLýDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanLyDoanhThu2.BringToFront();
        }

        private void quanLyBan1_Load(object sender, EventArgs e)
        {

        }

        private void quanLyDoanhThu2_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanLyTaiKhoan1.BringToFront();
        }
    }
}

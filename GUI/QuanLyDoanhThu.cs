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
    public partial class QuanLyDoanhThu : UserControl
    {
        public QuanLyDoanhThu()
        {
            InitializeComponent();
            Load();
        }

        private void QuanLyDoanhThu_Load(object sender, EventArgs e)
        {
           
        }

        private void panDanhThuContent_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Load()
        {
            dgvSanPhamBanDuoc.DataSource = BUS.DoanhThuBUS.Instance.getSanPhamDaBan();
            dgvNguyenLieuTrongKho.DataSource = BUS.NguyenLieuBUS.Instance.listNguyenLieu();
            txtTongQuyHienTai.Text = BUS.DoanhThuBUS.Instance.getTongDoanhThu() + " " + "VNĐ";
            txtDoanhThuThangNay.Text = BUS.DoanhThuBUS.Instance.getDoanhThuTheoThang()+ " " + "VNĐ";
            txtDoanhThuHomNay.Text = BUS.DoanhThuBUS.Instance.getDoanhThuTheoNgay()+ " " + "VNĐ";
            txtChi.Text = BUS.DoanhThuBUS.Instance.getChiHomNay()+ " " + "VNĐ";

        }
        
        
    }
}

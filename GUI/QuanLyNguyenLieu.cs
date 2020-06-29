using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class QuanLyNguyenLieu : UserControl
    {
        public string messageDeleteSucces = "Xóa nguyên liệu thành công";
        public string messageDeleteFail = "Xóa nguyên liêu thất bại";
        public string message = "Vui lòng nhập đầy đủ thông tin";
        public string messageUdateSuccess = "Cập nhật thành công";
        public string messageUpdateFail = "Cập nhật thất bại";
        public string messageInsertSucces = "Thêm nguyên liệu thành công";
        public string messageInsertFail = "Thêm nguyên liệu thất bại";
        
        public QuanLyNguyenLieu()
        {
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            dgv_NguyenLieu.DataSource = BUS.NguyenLieuBUS.Instance.listNguyenLieu();
            reset(sender, e);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

            //dgv_NguyenLieu.DataSource = BUS.NguyenLieuBUS.Instance.TimKiemNguyenLieuBUS(txt_TimKiem.Text);
        }

        private void btn_LuuLai_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text == "" || txtTenNL.Text == "" || txtDonViTinh.Text == "" || txtDonGia.Text == "")
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (BUS.NguyenLieuBUS.Instance.ThemNguyenLieu(txtMaNL.Text, txtTenNL.Text, txtDonViTinh.Text, txtDonGia.Text) > 0)
                {
                    MessageBox.Show(messageInsertSucces, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLySanPham_Load(sender, e);
                    reset(sender, e);
                }
                else
                    MessageBox.Show(messageInsertFail,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void reset(object sender, EventArgs e)
        {
            txtMaNL.ReadOnly = false;
            txtMaNL.Text = null;
            txtTenNL.Text = null;
            txtDonViTinh.Text = null;
            txtDonGia.Text = null;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            if (txtMaNL.Text == "" || txtTenNL.Text == "" || txtDonViTinh.Text == "" || txtDonGia.Text == "")
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                if (NguyenLieuBUS.Instance.CapNhatNguyeLieu(txtMaNL.Text, txtTenNL.Text, txtDonViTinh.Text, txtDonGia.Text) > 0)
                {
                    MessageBox.Show(messageUdateSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLySanPham_Load(sender, e);
                    reset(sender, e);
                }
                else
                    MessageBox.Show(messageUpdateFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string value = txtMaNL.Text;
            if (BUS.NguyenLieuBUS.Instance.XoaNguyenLieu(value) > 0)
            {
                MessageBox.Show(messageDeleteSucces, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuanLySanPham_Load(sender, e);
                reset(sender, e);
            }
            else
                MessageBox.Show(messageDeleteFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgv_NguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNL.ReadOnly = true;
            if (e.RowIndex < 0)
                return;

            else
            {

                txtMaNL.Text = dgv_NguyenLieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNL.Text = dgv_NguyenLieu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonViTinh.Text = dgv_NguyenLieu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonGia.Text = dgv_NguyenLieu.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

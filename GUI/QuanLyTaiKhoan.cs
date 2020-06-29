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
    public partial class QuanLyTaiKhoan : UserControl
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = BUS.TaiKhoanBUS.Intance.GetListTaiKhoan();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || cboLoaiTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                int loai;
                if (cboLoaiTK.Text == "Admin")
                    loai = 1;
                else if (cboLoaiTK.Text == "Chủ")
                    loai = 2;
                else
                    loai = 3;
                if (BUS.TaiKhoanBUS.Intance.AddTaiKhoan(username, password, loai) >= 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reset();
                }
            }

        }
        private void reset()
        {
            txtTenNV.ResetText();
            txtUsername.ResetText();
            txtPassword.ResetText();
            cboLoaiTK.Text = "";
            cboTrangThai.Text = "";
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                txtTenNV.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUsername.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPassword.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboLoaiTK.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString();
                cboTrangThai.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }
    }
}

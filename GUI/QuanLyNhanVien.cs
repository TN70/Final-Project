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
    public partial class QuanLyNhanVien : UserControl
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            load();
            //ChucVuNV();
          

        }
        string CorrectFileName = null;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    CorrectFileName = System.IO.Path.GetFileName(open.FileName);
                    System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFileName);

                    pic.Image = Image.FromFile(paths + "\\Images\\" + CorrectFileName);
                    MessageBox.Show("Tải ảnh thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ảnh!");
                }
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if(txtTenNV.Text==""||txtSDT.Text==""||txtDiaChi.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                //DateTime ngayVaoLam = Convert.ToDateTime(dtpNgayVaoLam.Value.ToString("yyyy/MM/dd"));
                //if (BUS.NhanVienBUS.Instance.ThemNhanVien(txtTenNV.Text, txtDiaChi.Text, txtSDT.Text, ngayVaoLam, "\\Images\\" + CorrectFileName, cboChucVu.Text) >= 1)
                //{
                //    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    load();
                //}
                //else
                //{
                //    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    load();
                //}
            }
         
        }

      

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
<<<<<<< HEAD
                dtpNgayVaoLam.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text= dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text= dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                cboChucVu.Text= dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
=======
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayVaoLam.Text= dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMaNV.Text= dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                cboChucVu.Text= dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                //pic.Image = Image.FromFile(paths + dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString());
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text=="")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            else
            {
                int ID = int.Parse(txtMaNV.Text);
                if (BUS.NhanVienBUS.Instance.XoaNhanVien(ID) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
            }         
        }
        private void load()
        {
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            pic.Image = null;
            dgvNhanVien.DataSource = BUS.NhanVienBUS.Instance.listNhanVien();
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = int.Parse(txtMaNV.Text);
                if(BUS.NhanVienBUS.Instance.CapNhatNhanVien(txtTenNV.Text,txtDiaChi.Text,txtSDT.Text,dtpNgayVaoLam.Text,ID,cboChucVu.Text)>0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }    
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    load();
                }    
            }    
        }

        public void ChucVuNV()
        {
            cboChucVu.DataSource = BUS.NhanVienBUS.Instance.ChucVuNV();
            cboChucVu.DisplayMember = "TenLoai";
            cboChucVu.ValueMember = "TenLoai";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

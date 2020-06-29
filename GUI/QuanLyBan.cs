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
using DTO;
namespace GUI
{
    public partial class QuanLyBan : UserControl
    {
        public QuanLyBan()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyBan_Load_1(object sender, EventArgs e)
        {
            List<TableDTO> lstTable = TableBus.Instance.LoadTable();
            dtgvQLBan.DataSource = lstTable;
            cboBan.Text = "Mã bàn";
        }

        private void dtgvQLBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string trangThai1 = "Đang phục vụ";
            string trangThai2 = "Trống";
            string tinhTrang1 = "Dùng được";
            string tinhTrang2 = "Không dùng được";
          
            if (e.RowIndex < 0)
                return;
            else
            {
                txtMaBan.Text = dtgvQLBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoGhe.Text = dtgvQLBan.Rows[e.RowIndex].Cells[1].Value.ToString();

                int iTrangThai = (int)dtgvQLBan.Rows[e.RowIndex].Cells[2].Value;
                if (iTrangThai == 1)
                    comboBox2.Text = trangThai1;
                else if(iTrangThai==0)
                    comboBox2.Text = trangThai2;

                int iTinhTrang = (int)dtgvQLBan.Rows[e.RowIndex].Cells[3].Value;
                if (iTinhTrang == 1)
                    cboTinhTrang.Text = tinhTrang1;
                else if(iTinhTrang==0)
                    cboTinhTrang.Text = tinhTrang2;
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoGhe.Text == "" || cboTinhTrang.Text == "" || comboBox2.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int soGhe = Convert.ToInt32(txtSoGhe.Text);
                int tinhtrang;
                if (cboTinhTrang.Text == "Dùng được")
                    tinhtrang = 1;
                else
                    tinhtrang = 0;
                int trangthai;
                if (comboBox2.Text == "Trống")
                    trangthai = 1;
                else
                    trangthai = 0;
                if (BUS.TableBus.Instance.InsertBan(soGhe, trangthai, tinhtrang) > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLyBan_Load_1(sender, e);
                }      
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuanLyBan_Load_1(sender, e);
                }    
                   
            }    
           
            
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaBan.ResetText();
            txtSoGhe.ResetText();
            cboTinhTrang.ResetText();
            comboBox2.ResetText();
        }
        int ChangeMaban(string maBan)
        {
            string ma = maBan.Substring(4);

            int soBan = Convert.ToInt32(ma);
            return soBan;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
                MessageBox.Show("Vui lòng chọn bàn cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int soGhe = Convert.ToInt32(txtSoGhe.Text);
                int maBan = ChangeMaban(txtMaBan.Text);
                int tinhtrang;
                if (cboTinhTrang.Text.Equals("Dùng được"))
                    tinhtrang = 1;
                else
                    tinhtrang = 0;
                int trangthai;
                if (comboBox2.Text.Equals("Trống"))
                    trangthai = 1;
                else
                    trangthai = 0;
                if (BUS.TableBus.Instance.update(maBan, trangthai, tinhtrang, soGhe)>0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLyBan_Load_1(sender, e);
                } 
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuanLyBan_Load_1(sender, e);
                }    
                    

            }    

;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string cbo = cboBan.Text;
            string txt = txtBan.Text;
            dtgvQLBan.DataSource = TableBus.Instance.listYeuCau(cbo, txt);
        }
    }
}

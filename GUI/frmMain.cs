using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmMain : Form
    {
        public TaiKhoan TaiKhoan1 = new TaiKhoan();
        public void funData(TextBox txtUser)
        {
            lblLoaiTaiKhoan.Text = txtUser.Text;
        }
        public void funDataTk(TaiKhoan tkUser)
        {
            TaiKhoan1 = tkUser;
            lblLoaiTaiKhoan.Text = tkUser.UserName;
        }
        public frmMain()
        {
            InitializeComponent();
            timeBlock.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //trangChu1.BringToFront();
            //banHang1.maNV = TaiKhoan1.MaNV;
            if(TaiKhoan1.MaLoai==2)
            {
                btnQuanLy.Enabled = false;
                btnThongKe.Enabled = false;
            }
            else if(TaiKhoan1.MaLoai==3)
            {
                btnThongKe.Enabled = false;
            }
            banHang1.BringToFront();

        }
        
       

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            trangChu1.BringToFront();
            //panHover.Top = btnTrangChu.Top;
            //panHover.Height = btnTrangChu.Height;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {

            //panHover.Top = btnBanHang.Top;
            //panHover.Height = btnBanHang.Height;
            banHang1.BringToFront();

        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {

            //panHover.Top = btnQuanLy.Top;
            //panHover.Height = btnQuanLy.Height;
            quanLy1.BringToFront();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            thongKe1.BringToFront();
            //panHover.Top = btnThongKe.Top;
            //panHover.Height = btnThongKe.Height;
            uctThongKe1.BringToFront();
        }

        private void btnInfomation_Click(object sender, EventArgs e)
        {

            //panHover.Top = btnInfomation.Top;
            //panHover.Height = btnInfomation.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            
            frm.ShowDialog();
        }

        private void timeBlock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int giay = now.Second;
            int phut = now.Minute;
            int gio = now.Hour;
            giay++;
            if (giay > 59)
            {
                phut++;
                giay = 0;
            }
            if (phut > 59)
            {
                gio++;
                phut = 0;
            }
            if (gio > 24)
            {
                gio = 0;
                phut = 0;
                giay = 0;
            }
            if (giay < 10)
            {
                lblGiay.Text = "0" + giay;
            }
            else
            {
                lblGiay.Text = giay + "";
            }
            if (phut < 10)
            {
                lblPhut.Text = "0" + phut + ":";
            }
            else
            {
                lblPhut.Text = phut + "" + ":";
            }
            if (giay < 10)
            {
                lblGiay.Text = "0" + giay;
            }
            else
            {
                lblGiay.Text = giay + "";
            }
            if (gio < 10)
            {
                lblGio.Text = "0" + gio + ":";
            }
            else
            {
                lblGio.Text = gio + "" + ":";
            }
        }

        private void panTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void banHang1_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }
    }
}

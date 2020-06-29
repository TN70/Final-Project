using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public delegate void delPassUser(TextBox text);
        public delegate void delPasssTaiKhoan(TaiKhoan tk);
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
           //try
           //     {
                    string userName = txtName.Text;
                    string passWord = txtPassWord.Text;
            TaiKhoan tKhoan = new TaiKhoan();
            if (DangNhapBUS.Instance.Login(userName,passWord))
                    {
                    frmMain main = new frmMain();
                    this.Hide();
                //Lay Ra Tai Khoan
                    tKhoan = TaiKhoanBUS.Intance.ChonTaiKhoanDangNhap(userName);
                    delPasssTaiKhoan delTk=new delPasssTaiKhoan(main.funDataTk);
                delTk(tKhoan);
                    //delPassUser del = new delPassUser(main.funData);
                    //del(this.txtName);
                    main.ShowDialog();
                    }
                    else
                    {
                    MessageBox.Show("Đăng nhập Không thành Công", "Thông báo");
                    }
                //}
           //catch (Exception ex)
           //{
           //     MessageBox.Show(ex.Message, "Thông báo");
           //}
            

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sựu muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                Application.Exit();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void grb_DangNhap_Enter(object sender, EventArgs e)
        {

        }
    }
}

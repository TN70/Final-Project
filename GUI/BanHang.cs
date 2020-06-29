using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class BanHang : UserControl
    {
        static int width = 77;
        static int height = 80;
        static float tongTien = 0;
        static int maBanClick = -1;
         public   int maNV { get; set; }
        
        Button myButtonClick = new Button();
        public BanHang()
        {
            InitializeComponent();

        }
        // load ban
        void LoadBan()
        {
            fPannelBan.Controls.Clear();
            List<TableDTO> listTableDTO = TableBus.Instance.LoadTable();
            foreach (TableDTO item in listTableDTO)
            {
                Button btn = new Button();
                btn.Width = width;
                btn.Height = height;
                btn.Tag = item;
                btn.ImageKey = "icons8-table-26.png";
                btn.ImageList = this.imageListIcon;
                btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Click += btn_Click;
                
                if (item.ITrangThai == 0)
                {
                    //drvHoaDon.Visible = false;
                    btn.BackColor = System.Drawing.Color.PeachPuff;

                }
                else if (item.ITrangThai == 1)
                {
                    //drvHoaDon.Visible = false;
                    btn.BackColor = System.Drawing.Color.LightGray;
                }
              
                string MaBan =ChangeMaban(item.IMaBan).ToString();
                btn.Text = "Ban " + MaBan + "";
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                fPannelBan.Controls.Add(btn);
             
            }
        }
        int  ChangeMaban(string maBan)
        {
            string ma = maBan.Substring(4);
           
            int soBan = Convert.ToInt32(ma);
            return soBan;
        }
        //Bắt sự kiện click
        private void btn_Click(object sender, EventArgs e)
        {
            tongTien = 0;           
            string  idBan = ((sender as Button).Tag as TableDTO).IMaBan;
            //lay ra ma ban dang duoc click 
            maBanClick = ChangeMaban(idBan);
            //gán Cho drv với đối tượng là mã bàn
            drvBillInfo.Tag = (sender as Button).Tag;
            lblBan.Text = maBanClick.ToString();
            //Lay ra Trang thai cua ban
            int Trangthai = ((sender as Button).Tag as TableDTO).ITrangThai;           
            if (Trangthai == 0)
            {
                lblTrangThai.Text = "Trạng thái: trống";
                drvBillInfo.DataSource = null;
            

            }
            else if (Trangthai == 1)
            {
                lblTrangThai.Text = "Trạng thái: Đang Phục vụ";
                drvBillInfo.DataSource = BillInfoBus.Instance.getBillInfoByIDTable(maBanClick, ref tongTien);
                txtTongTien.Text = tongTien + "";
            }
            myButtonClick = (sender as Button);



        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(maBanClick>0)
            {
                //lau ra bill hien tai
                if (numSoLuong.Value > 0)
                {
                    int idBill = BillBus.Instance.GetUncheckBillIDByTableID(maBanClick);
                    int idMenu = (cboMenu.SelectedItem as MenuDTO).ID;
                    float giamGia = (float)numGiamGia.Value;
                    int soLuong = (int)numSoLuong.Value;
                    int gia = 0;

                    int exec;

                    if (idBill == -1)
                    {
                        try
                        {
                            gia = Convert.ToInt32(txtGia.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Vui Lòng Nhập Lại Giá!", "Thông Báo");
                        }

                        if (gia > 0)
                        {
                            BillBus.Instance.InsertBill(maBanClick, maNV);
                            int maHD = BillBus.Instance.GetMaxIDBill();
                            BillInfoBus.Instance.InsertBillInfo(maHD, idMenu, soLuong, giamGia, gia);
                            exec = TableBus.Instance.UpdateStatusBan(maBanClick, 1);
                            
                            
                            fPannelBan.Controls.Clear();

                            LoadBan();
                        

                        }
                        else
                        {
                            MessageBox.Show("Vui Lòng Nhập Lại Giá!", "Thông Báo");
                        }
                    }
                    else
                    {
                        BillInfoBus.Instance.InsertBillInfo(idBill, idMenu, soLuong, giamGia, 15000);
                    }
                    drvBillInfo.DataSource = BillInfoBus.Instance.getBillInfoByIDTable(maBanClick, ref tongTien);
                    cboBanTrong.DataSource = TableBus.Instance.LoadListTableNull();
                }
                else
                {
                    //Neu so luong la 0
                    MessageBox.Show("Vui Lòng Nhập Số Lượng", "Thông Báo");
                }

            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Bàn Để Thanh Toán", "Thông Báo");
            }
       
           

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int idBill = BillBus.Instance.GetUncheckBillIDByTableID(maBanClick);
                bool resultBill;
                if (idBill == -1)
                {
                    MessageBox.Show("Vui lòng chọn bàn đang phục vụ", "Thông báo");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Xác Nhận Thanh Toán!", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if(dialogResult==DialogResult.Yes)
                    {
                        resultBill = BillBus.Instance.UpdateBill(idBill);
                        resultBill =BUS.TableBus.Instance.CapNhatBan(maBanClick, 0);
                        LoadBan();
<<<<<<< HEAD
                        
                       
=======
                        //uctHoaDon uctHd = new uctHoaDon();
                        //uctHd.BringToFront();
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng chọn 1 bàn đang phục vụ", "Thông báo");
            }
          
        }

        private void billInfoDTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if(maBanClick==0)
            {
                MessageBox.Show("Vui lòng Chọn Bàn Cần Chuyển", "Thông Báo");
            }
            else
            {
                tongTien = 0;
                //Lay ra ban mơi từ combobox
         
                int banMoi = Convert.ToInt32(cboBanTrong.Text);
                //Chuyen Ban
                BillBus.Instance.DoiBan(maBanClick, banMoi);
                //Cap Nhat Ban Cu
                int exec = TableBus.Instance.UpdateStatusBan(maBanClick, 0);
                //Cap Nhât Ban Mới
                exec = TableBus.Instance.UpdateStatusBan(banMoi, 1);
                //Lay ra mã ban hienj hanh
                maBanClick = banMoi;
                lblBan.Text = maBanClick + "";
                //Load Loai Danh Sach Ban
                LoadBan();
                //Load Vao datagrid view
                drvBillInfo.DataSource = BillInfoBus.Instance.getBillInfoByIDTable(maBanClick, ref tongTien);

            }

     
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            cboLoaiMenu.DataSource = LoaiMenuBus.Instance.ListLoaiMenu();
            LoadBan();
            //Load ra tbale trong

            cboBanTrong.DataSource = TableBus.Instance.LoadListTableNull();
           
            int idLoaiMenu = (int)cboLoaiMenu.SelectedValue;
            List<MenuDTO> listMenu = MenuBus.Instance.ListMenuByID(idLoaiMenu);
            cboMenu.DataSource = listMenu;

        }
        
        
        private void cboBanTrong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtGia.Text = MenuBus.Instance.HienThiDonGia(cboMenu.SelectedValue.ToString());
        }

        private void cboLoaiMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idLoaiMenu = (int)cboLoaiMenu.SelectedValue;
            List<MenuDTO> listMenu = MenuBus.Instance.ListMenuByID(idLoaiMenu);
            cboMenu.DataSource = listMenu;
        }

        private void drvBillInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (drvBillInfo.Columns[e.ColumnIndex].Name == "Delete")
            //{
            //    if(MessageBox.Show("Bạn muốn hủy món này ?", "Hủy món", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            //    {
            //        billInfoDTOBindingSource.RemoveCurrent();
            //    }    
            //}
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtGia.Text, "  ^ [0-9]"))
            {
                txtGia.Text = "";
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void fPannelBan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

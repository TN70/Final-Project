using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
   public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Intance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
            private set { TaiKhoanBUS.Intance = value; }
        }

        public List<TaiKhoanDTO> GetListTaiKhoan()
        {
            return DAO.TaiKhoanDAO.Intance.GetListTaiKhoan();
        }
        public int AddTaiKhoan(string username, string pass, int maloai)
        {
            return DAO.TaiKhoanDAO.Intance.AddTaiKhoan(username, pass, maloai);
        }
        public TaiKhoan ChonTaiKhoanDangNhap(string user)
        {
            return TaiKhoanDAO.Intance.ChonTaiKhoanDangNhap(user);
        }
    }
}

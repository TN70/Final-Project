using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
            private set => NhanVienBUS.Instance = value;
        }

        public List<NhanVienDTO> listNhanVien()
        {
            return NhanVienDAO.Intance.getListNhanVien();
        }

        public int ThemNhanVien(string TenNV, string DiaChi, string SDT, DateTime NgayVaoLam, string HinhAnh,string chucvu)
        {
            return DAO.NhanVienDAO.Intance.ThemNhanVien(TenNV,DiaChi,SDT,NgayVaoLam,HinhAnh,chucvu);
        }

        public int CapNhatNhanVien(string tenNV, string diachi, string sdt, string ngayVaoLam, int id,string chucvu)
        {
            return DAO.NhanVienDAO.Intance.CapNhatNhanVien(tenNV, diachi, sdt, ngayVaoLam,id,chucvu);
        }
        public int XoaNhanVien(int ID)
        {
            return DAO.NhanVienDAO.Intance.XoaNhanVien(ID);
        }

        public List<NhanVienDTO> TimKiemNV(string name)
        {

            return DAO.NhanVienDAO.Intance.TimKiemNV(name);
        }
        public List<NhanVienDTO> ChucVuNV()
        {
            return DAO.NhanVienDAO.Intance.ChucVuNV();
        }



    }
}

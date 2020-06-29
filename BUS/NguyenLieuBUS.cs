using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
 

namespace BUS
{
    public class NguyenLieuBUS
    {
        private static NguyenLieuBUS instance;

        public static NguyenLieuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NguyenLieuBUS();
                return instance;
            }
            private set => NguyenLieuBUS.Instance = value; 
        }

        private NguyenLieuBUS()
        {

        }

        public List<NguyenLieuDTO> listNguyenLieu()
        {
            return NguyenLieuDAO.Intance.getListNguyenLieu();
        }

        public List<NguyenLieuDTO> TimKiemNguyenLieuBUS(string value)
        {
            return NguyenLieuDAO.Intance.TimKiemNguyenLieuDAO(value);
        }

        public int ThemNguyenLieu(string MaNL, string TenNL, string DonViTinh, string DonGia)
        {

            return NguyenLieuDAO.Intance.ThemNguyenLieu(MaNL, TenNL, DonViTinh, DonGia);
        }

        public int XoaNguyenLieu(string value)
        {
            return NguyenLieuDAO.Intance.XoaNguyenLieu(value);
        }

        public int CapNhatNguyeLieu(string MaNL, string TenNL, string DonViTinh, string DonGia)
        {
            return NguyenLieuDAO.Intance.CapNhatNguyenLieu(MaNL, TenNL, DonViTinh, DonGia);
        }
    }
}

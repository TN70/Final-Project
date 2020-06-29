using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public  class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Intance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set { NhanVienDAO.Intance = value; }
        }


        public List<NhanVienDTO> getListNhanVien()
        {
<<<<<<< HEAD
            string strSQL = "select * from nhanvien where trangthai=1 ";
=======
            string strSQL = "select a.ID, a.TenNV, a.NgayVaoLam,a.SDT,a.diachi,a.HinhAnh,c.TenLoai from NHANVIEN a, TAIKHOAN b, LOAITK c where a.ID=b.MaNV and b.MaLoai=c.ID and a.trangthai=1 ";
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            List<NhanVienDTO> listData = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(strSQL);
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO item = new NhanVienDTO(row);
                listData.Add(item);
            }
            return listData;
        }

        public int ThemNhanVien(string TenNV, string DiaChi, string SDT, DateTime NgayVaoLam, string HinhAnh, string chucvu)
        {
            int result = 0;
            string sql = string.Format("INSERT INTO NHANVIEN(TenNV, NgayVaoLam,SDT, diachi, HinhAnh) VALUES(N'{0}', '{1}','{2}',N'{3}',N'{4}')", TenNV, NgayVaoLam, SDT, DiaChi, HinhAnh);
            result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result;
        }

        public int CapNhatNhanVien(string tenNV, string diaChi, string sdt, string ngayVaoLam,int id, string chucvu)
        {
            int result = 0;
<<<<<<< HEAD
            string sql = string.Format("UPDATE NHANVIEN SET TenNV=N'{0}',NgayVaoLam='{1}',SDT='{2}',diachi=N'{3}', ChucVu=N'{4}' WHERE ID='{5}'", tenNV, ngayVaoLam, sdt, diaChi,chucvu,id);
=======
            string sql = string.Format("UPDATE NHANVIEN SET TenNV=N'{0}',NgayVaoLam='{1}',SDT='{2}',diachi=N'{3}' WHERE ID='{4}'   update set c.TenLoai = N'{5}' from NHANVIEN a, TAIKHOAN b, LOAITK c where a.ID = b.MaNV and b.MaLoai = c.ID and  a.ID = {6} ", tenNV, ngayVaoLam, sdt, diaChi,id,chucvu,id);
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result;
        }

        public int XoaNhanVien(int ID)
        {
            int result = 0;
            string sql = string.Format("UPDATE NHANVIEN SET TrangThai=0 WHERE ID={0}", ID);
            result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result;
        }

        public List<NhanVienDTO> ChucVuNV ()
        {
            string strSQL = string.Format("SELECT TenLoai FROM LOAITK");
            List<NhanVienDTO> listData = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(strSQL);
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO item = new NhanVienDTO(row);
                listData.Add(item);
            }
            return listData;

        }

        public List<NhanVienDTO> TimKiemNV(string name)
        {
            string strSQL =string.Format( "SELECT * FROM NHANVIEN WHERE TenNV LIKE N'{0}%'",name);
            List<NhanVienDTO> listData = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(strSQL);
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO item = new NhanVienDTO(row);
                listData.Add(item);
            }
            return listData;

        }
    }
}

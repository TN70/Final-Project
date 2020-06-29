using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public  class NguyenLieuDAO
    {
        private static NguyenLieuDAO instance;

        public static NguyenLieuDAO Intance  
        {
            get
            {
                if (instance == null)
                    instance = new NguyenLieuDAO();
                return instance;
            }
            private set { NguyenLieuDAO.Intance = value; }
        }
       
        public List<NguyenLieuDTO> getListNguyenLieu()
        {
            string strSQL = "SELECT * FROM NGUYENLIEU WHERE TrangThai=1  ";
            List<NguyenLieuDTO> listData = new List<NguyenLieuDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(strSQL);
            foreach (DataRow row in data.Rows)
            {
                NguyenLieuDTO item = new NguyenLieuDTO(row);
                listData.Add(item);
            }
            return listData;
        }
        public List<NguyenLieuDTO> TimKiemNguyenLieuDAO(String value)
        {
            string strSQL = "SELECT * FROM NGUYENLIEU WHERE TENNL LIKE N'{0}%'";
            string SqlFormat = string.Format(strSQL, value);
            List<NguyenLieuDTO> listData = new List<NguyenLieuDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(SqlFormat);
            foreach(DataRow row in data.Rows)
            {
                NguyenLieuDTO item = new NguyenLieuDTO(row);
                listData.Add(item);
            }
            return listData;
        }
        public int ThemNguyenLieu(string MaNL, string TenNL, string DonViTinh, string DonGia)
        {
            int data;
            string strSQL = "INSERT INTO NGUYENLIEU(MANL,TENNL,DONVITINH,DONGIA,TRANGTHAI) VALUES('{0}',N'{1}',N'{2}','{3}',1)";
            string SqlFormat = string.Format(strSQL, MaNL, TenNL, DonViTinh, DonGia);
            data = DataProvider.Instance.ExecuteNonQuery(SqlFormat);
            return data;
        }

        public int XoaNguyenLieu(string value)
        {
            int data;
            string strSQL = " UPDATE NGUYENLIEU SET TRANGTHAI=0 WHERE MANL='{0}'";
            string SqlFormat = string.Format(strSQL,value);
            data = DataProvider.Instance.ExecuteNonQuery(SqlFormat);
            return data;     
        }
        public int CapNhatNguyenLieu(string MaNL, string TenNL, string DonViTinh, string DonGia)
        {
            int data;
            string strSQL = "UPDATE NGUYENLIEU SET TENNL=N'{0}', DONVITINH=N'{1}', DONGIA='{2}' WHERE MANL='{3}'";
            string SqlFormat = string.Format(strSQL, TenNL, DonViTinh, DonGia,MaNL);
            data = DataProvider.Instance.ExecuteNonQuery(SqlFormat);
            return data;
        }

    }
    
}

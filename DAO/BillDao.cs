using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        private QuanLyQuanCaFeEntities _qlcfEf = new QuanLyQuanCaFeEntities();

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set { BillDAO.Instance = value; }
        }
        public void InsertBill(int idTable,int idNhanVien)
        {
            string sqlInsert = "exec inserBill "+idTable+", "+idNhanVien;
            
            DataProvider.Instance.ExecuteNonQuery(sqlInsert);
        }
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE MaBan = " + id + " AND trangthai = 0");

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }


        public int GetMaxIDBill()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM HoaDon");
            //try
            //{
                
            //}
            //catch
            //{
            //    return 1;
            //}
        }
        public void DoiBan(int idCu, int idMoi)
        {

            string execChuyenBan = "exec ChuyenBan " + idCu + " , " + idMoi;
            int exec = DataProvider.Instance.ExecuteNonQuery(execChuyenBan);
        }
        public bool UpdateBill(int Mabill)
        {
            try
            {
                HOADON bill = new HOADON();
                bill = _qlcfEf.HOADONs.SingleOrDefault(u => u.ID==Mabill);
                DateTime now=DateTime.Now;
                bill.trangthai = 1;
                bill.CheckOut = now;
                _qlcfEf.SaveChanges();
                return true;
                

            }
            catch(Exception e)
            {
                return false;
            }
        }
<<<<<<< HEAD
        public List<BillDTO> getListHD()
        {
            string query = "select * from HOADON where trangthai = 1 order by CheckOut desc";
            List<BillDTO> listData = new List<BillDTO>();
=======
<<<<<<< HEAD
        public List<BillDTO> getListHD(string tuNgay, string denNgay)
        {
            string query = string.Format("exec getListHD '{0}', '{1}'", tuNgay, denNgay);
            List<BillDTO> listData = new List<BillDTO>();
=======

        public List<BillDTO> getListHD(string tuNgay, string denNgay)
        {
            
            string query = string.Format("SELECT a.ID, b.TenNV, a.NgayLap, a.trangthai, a.MaBan, a.CheckOut from HOADON a, NHANVIEN b where a.MaNV = B.ID and a.Checkout between '{0}' and '{1}'", tuNgay, denNgay);
            List<BillDTO> lst = new List<BillDTO>();
>>>>>>> d87ad6287aa2d11f00defadc1326879aaa8d94ec
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillDTO item = new BillDTO(row);
<<<<<<< HEAD
                listData.Add(item);
            }
            return listData;   
        }
        public List<BillDTO> getListHD(string tuNgay, string denNgay)
        {

            string query = string.Format("SELECT a.ID, a.MaNV, a.NgayLap, a.trangthai, a.MaBan, a.CheckOut from HOADON a, NHANVIEN b where a.MaNV = B.ID and a.Checkout between '{0}' and '{1}'", tuNgay, denNgay);
=======
<<<<<<< HEAD
                listData.Add(item);
            }
            return listData;
        }
        public List<BillDTO> getListHD()
        {
            string query = "select * from HOADON where trangthai = 1 order by CheckOut desc";
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            List<BillDTO> listData = new List<BillDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillDTO item = new BillDTO(row);
                listData.Add(item);
            }
            return listData;
<<<<<<< HEAD
=======
=======
                lst.Add(item);
            }
            return lst;
>>>>>>> d87ad6287aa2d11f00defadc1326879aaa8d94ec
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class BillInfoDao
    {
        private static BillInfoDao instance;
        private BillInfoDao()
        {

        }

        public static BillInfoDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDao();
                return instance;
            }

            private set => instance = value;
        }
        public List<BillInfoDTO> getBillInfoByIDTable(int idTable,ref float tongTien)
        {
            
            List<BillInfoDTO> listBillInfo = new List<BillInfoDTO>();
            string sqlQuery = "exec GetBill " + idTable;
            DataTable dt = DataProvider.Instance.ExecuteQuery(sqlQuery);
            foreach(DataRow dr in dt.Rows)
            {
               
                BillInfoDTO billInfo = new BillInfoDTO(dr);
                tongTien = tongTien + billInfo.ThanhTien;
               listBillInfo.Add(billInfo);
            }
            return listBillInfo;
        }
        public List<BillInfoDTO> getBillInfoByIDTable(int idTable)
        {

            List<BillInfoDTO> listBillInfo = new List<BillInfoDTO>();
            string sqlQuery = "exec GetBill " + idTable;
            DataTable dt = DataProvider.Instance.ExecuteQuery(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {

                BillInfoDTO billInfo = new BillInfoDTO(dr);
          
                listBillInfo.Add(billInfo);
            }
            return listBillInfo;
        }
        public void InsertBillInfo(int maHD,int maMenu,int soLuong, float giamGia,float giaBan)
        {
            string sqlInsert = "exec insertBillInfo {0},{1},{2},{3},{4}";
            string sqlData = string.Format(sqlInsert, maHD, maMenu, soLuong, giamGia, giaBan);
          
            DataProvider.Instance.ExecuteNonQuery(sqlData);
        }


      
    }
}

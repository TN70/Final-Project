using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Data.Entity.Core.Metadata.Edm;
using System.Runtime.Remoting.Messaging;

namespace DAO
{
    public class DoanhThuDAO
    {
        private static DoanhThuDAO instance;

        public static DoanhThuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoanhThuDAO();
                }
                return instance;
            }
            private set { DoanhThuDAO.instance = value; }
        }


        //Lấy các sản phẩm đã bán trong chi tiết hóa đơn
        public List<DoanhThuDTO> getSanPhamDaBan()
        {
            List<DoanhThuDTO> list = new List<DoanhThuDTO>();
            string query = "SELECT b.TenMenu, a.GiaBan, a.SoLuong, a.GiamGia/100 as GiamGia FROM CHITIETHOADON a, MENU b  WHERE a.MaMenu=b.ID ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DoanhThuDTO item = new DoanhThuDTO(row);
                list.Add(item);
            }
            return list;
        }

        //Lấy tổng doanh thu
        public string getTongDoanhThu()
        {
            string Result = "";
            string query = "exec getTongDoanhThu";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                Result = dataRow["tongtien"].ToString();
            }
            return Result;
        }

        //Lấy doanh thu theo ngày
        public string getDoanhThuTheoNgay()
        {
            string result ="";
            string query = "SELECT SUM(SoLuong*GiaBan-(SoLuong*GiaBan*GiamGia)) tongtien FROM CHITIETHOADON WHERE DAY(NgayLap)= DAY(getdate())";
            
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if(data.Rows.Count == 0)
            {
                return "0";
            } 
            foreach(DataRow dataRow in data.Rows)
            {
                
                result = dataRow["tongtien"].ToString();
            }

            return result;
        }

        //Lấy doanh thu theo tháng
        public string getDoanhThuTheoThang()
        {
            string Result = "";
            string query = "SELECT SUM(SoLuong*GiaBan-(SoLuong*GiaBan*GiamGia)) tongtien FROM CHITIETHOADON WHERE MONTH(NgayLap)= MONTH(getdate())";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                Result = dataRow["tongtien"].ToString();
            }
            return Result;
        }

        //Lấy doanh thu được chi hôm nay
        public string getChiHomNay()
        {
            string result = "";
            string query = "SELECT SUM(SoLuong*DonGia) tongtien FROM CHITIETPHIEUNHAP WHERE DAY(NgayLap)= DAY(getdate())";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dataRow in data.Rows)
            {
                result = dataRow["tongtien"].ToString();
            }    
            return result;
        }
    }
}

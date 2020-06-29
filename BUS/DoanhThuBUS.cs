using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace BUS
{
    public class DoanhThuBUS
    {
        private static DoanhThuBUS instance;
        public static DoanhThuBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoanhThuBUS();
                }
                return instance;
            }
            private set { DoanhThuBUS.instance = value; }
        }

        public List<DoanhThuDTO> getSanPhamDaBan()
        {
            List<DoanhThuDTO> list = new List<DoanhThuDTO>();
            list = DAO.DoanhThuDAO.Instance.getSanPhamDaBan();
            return list;
        }

        public string getTongDoanhThu()
        {
            string Result;
            Result = DAO.DoanhThuDAO.Instance.getTongDoanhThu();
            return Result;
        }
        public string getDoanhThuTheoThang()
        {
            return DAO.DoanhThuDAO.Instance.getDoanhThuTheoThang();
        }
        public string getDoanhThuTheoNgay()
        {
            return DAO.DoanhThuDAO.Instance.getDoanhThuTheoNgay();
        }
        public string getChiHomNay()
        {
            return DAO.DoanhThuDAO.Instance.getChiHomNay();
        }
    }
}

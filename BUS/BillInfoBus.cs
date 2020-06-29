using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BillInfoBus
    {
        private static BillInfoBus instance;


        private BillInfoBus()
        {

        }

        public static BillInfoBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoBus();
                return instance;
            }
            private set
            {
                BillInfoBus.instance = value;
            }
        }
        public List<BillInfoDTO> getBillInfoByIDTable(int idTable, ref float tongTien)
        {

            return BillInfoDao.Instance.getBillInfoByIDTable(idTable, ref tongTien);
        }
        public void InsertBillInfo(int maHD, int maMenu, int soLuong, float giamGia, float giaBan)
        {
            BillInfoDao.Instance.InsertBillInfo(maHD, maMenu, soLuong, giamGia, giaBan);
        }
        public List<BillInfoDTO> getBillInfoByIDTable(int idTable)
        {
            return BillInfoDao.Instance.getBillInfoByIDTable(idTable);
        }
    }
}

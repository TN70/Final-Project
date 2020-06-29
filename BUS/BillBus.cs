using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BillBus
    {
        private static BillBus instance;


        private BillBus()
        {

        }

        public static BillBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBus();
                return instance;
            }
            private set
            {
                BillBus.instance = value;
            }
        }
        public int GetUncheckBillIDByTableID(int id)
        {
            return BillDAO.Instance.GetUncheckBillIDByTableID(id);
        }
        public int GetMaxIDBill()
        {
            return BillDAO.Instance.GetMaxIDBill();
        }
        public void InsertBill(int idTable, int idNhanVien)
        {
            BillDAO.Instance.InsertBill(idTable, idNhanVien);
        }
        public void DoiBan(int idCu, int idMoi)
        {
            BillDAO.Instance.DoiBan(idCu, idMoi);
        }
        public bool UpdateBill(int Mabill)
        {
            return BillDAO.Instance.UpdateBill(Mabill);
        }
<<<<<<< HEAD
        public List<BillDTO> getListHD()
        {
            return BillDAO.Instance.getListHD();
        }
=======
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
        public List<BillDTO> getListHD(string tuNgay, string denNgay)
        {
            return BillDAO.Instance.getListHD(tuNgay, denNgay);
        }
<<<<<<< HEAD

        
=======
<<<<<<< HEAD
        public List<BillDTO> getListHD()
        {
            return BillDAO.Instance.getListHD();
        }

=======
>>>>>>> d87ad6287aa2d11f00defadc1326879aaa8d94ec
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LoaiMenuBus
    {
        private static LoaiMenuBus instance;


        private LoaiMenuBus()
        {

        }

        public static LoaiMenuBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiMenuBus();
                return instance;
            }
            private set
            {
                LoaiMenuBus.instance = value;
            }
        }
        public List<LoaiMenuDTO> ListLoaiMenu()
        {
            return LoaiMenuDao.Instance.ListLoaiMenu();
        }
        public int GetIDLoaiMenu(string ten)
        {
            return LoaiMenuDao.Instance.GetIdLoaiMenu(ten);
        }
    }
}

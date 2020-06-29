using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class MenuBus
    {
        private static MenuBus instance;


        private MenuBus()
        {

        }

        public static MenuBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuBus();
                return instance;
            }
            private set
            {
                MenuBus.instance = value;
            }
        }
        public List<MenuDTO> ListMenuByID(int maLoai)
        {
            return MenuDao.Instance.ListMenuById(maLoai);
        }
        //public string HienThiDonGia(string tenMenu)
        //{
        //    return MenuDao.Instance.HienThiDonGia(tenMenu);
        //}


    }
}

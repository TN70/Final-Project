using System;
using DAO;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductBus
    {
        private static ProductBus instance;


        private ProductBus()
        {

        }

        public static ProductBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductBus();
                return instance;
            }
            private set { ProductBus.instance = value; }
        }
        public List<ProductDTO> GetListSanPham(string strWhere)
        {
            return ProductDao.Instance.dsSanPham(strWhere);
        }
    }
}

using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class ProductDao
    {
        private static ProductDao instance;

        public static ProductDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDao();
                }
                return instance;
            }
            private set { ProductDao.instance = value; }
        }
        public List<ProductDTO> dsSanPham(string strWhere)
        {
            List<ProductDTO> ds = new List<ProductDTO>();
            string sql = "select * from THUCUONG where MaThucUong like '"+strWhere+"%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach(DataRow item in data.Rows)
            {
                ProductDTO product = new ProductDTO(item);
                ds.Add(product);
            }
            return ds;
        }
    }
}

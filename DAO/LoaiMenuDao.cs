using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LoaiMenuDao
    {
        
        private static LoaiMenuDao instance;
        private LoaiMenuDao()
        {

        }

        public static LoaiMenuDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiMenuDao();
                return instance;
            }

            private set => instance = value;
        }
       public List<LoaiMenuDTO> ListLoaiMenu()
        {
            List<LoaiMenuDTO> listLoai = new List<LoaiMenuDTO>();
            listLoai =DataProvider.Instance._qlqcfEF.LOAIMENUs.Where(u => u.TrangThai == 0).Select(v
                => new LoaiMenuDTO
            {
                ID=v.ID,
                TenLoai=v.TenLoai,
                TrangThai=v.TrangThai
            }).ToList();
            return listLoai;
        }
        public int GetIdLoaiMenu(string tenMenu)
        {
            string strSql = "exec GetIdLoaiMenu " + tenMenu;
            int ID = -1 ;
            DataTable data = DataProvider.Instance.ExecuteQuery(strSql);
            if(data.Rows.Count>0)
            {
                DataRow dataRow = data.Rows[0];
                ID = (int)dataRow["ID"];

            }
            return ID;
            
        }
    }
}

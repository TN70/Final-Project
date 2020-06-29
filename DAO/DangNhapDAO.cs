using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhapDAO
    {
        private static DangNhapDAO instance;


        public static DangNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapDAO();
                return instance;
            }
            private set { DangNhapDAO.Instance = value; }
        }
        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM TaiKhoan WHERE UserName = N'" + userName + "' AND Pass = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }


    }
}

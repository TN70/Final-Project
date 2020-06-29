using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class DangNhapBUS
    {
    
            private static DangNhapBUS instance;


            private DangNhapBUS()
            {

            }

            public static DangNhapBUS Instance
            {
                get
                {
                    if (instance == null)
                        instance = new DangNhapBUS();
                    return instance;
                }
                private set
                {
                    DangNhapBUS.instance = value;
                }
            }
        
        public bool Login(string userName,string passWord)
        {
            return DangNhapDAO.Instance.Login(userName, passWord);
        }
    }
}

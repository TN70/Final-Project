using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        public BillDTO()
        {

        }
        private string tenTT;
        public int ID { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        //public int trangthai { get; set; }
        public int MaNV { get; set; }
        public int MaBan { get; set; }
        public Nullable<System.DateTime> CheckOut { get; set; }
        public string TenTT { get => tenTT; set => tenTT = value; }

        public BillDTO(DataRow dataRow)
        {
            this.ID = (int)dataRow["Id"];
<<<<<<< HEAD
            this.NgayLap =Convert.ToDateTime( dataRow["NgayLap"]);            
=======
            this.NgayLap =Convert.ToDateTime( dataRow["NgayLap"]);
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            int trangthai = (int)dataRow["trangthai"];
            this.MaNV = (int)dataRow["MaNV"];
            if(trangthai == 0)
            {
                this.TenTT = "Chưa Thanh Toán";
            } else
            {
                this.TenTT = "Đã thanh toán";
            }
            this.MaBan = (int)dataRow["MaBan"];
            this.CheckOut= Convert.ToDateTime(dataRow["CheckOut"]);

        }
     
    }
}

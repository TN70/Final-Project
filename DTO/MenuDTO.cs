using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MenuDTO
    {
        public int ID { get; set; }
        public string TenMenu { get; set; }
        public int MaLoai { get; set; }
        public int TrangThai { get; set; }

        public Nullable<double> DonGia { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiMenuDTO

    {
        public LoaiMenuDTO()
        {
            
        }

        public int ID { get; set; }
        public string TenLoai { get; set; }
        public int TrangThai { get; set; }
    }
}

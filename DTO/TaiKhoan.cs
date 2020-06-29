using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        int id;
        string userName;
        string pass;
        int maLoai;
        int maNV;

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => pass; set => pass = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public int MaNV { get => maNV; set => maNV = value; }
    }
}

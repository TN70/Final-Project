using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class TaiKhoanDTO
    {
        private string TenNV;
        private string Username;
        private string Password;
        private string TenLoai;
        private int TrangThai;

        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string TenLoai1 { get => TenLoai; set => TenLoai = value; }
        public int TrangThai1 { get => TrangThai; set => TrangThai = value; }

        public TaiKhoanDTO(string tennv, string user, string pass, string tenloai, int trangthai)
        {
            this.TenNV = tennv;
            this.Username = user;
            this.Password = pass;
            this.TenLoai = tenloai;
            this.TrangThai = trangthai;
        }
        public TaiKhoanDTO(DataRow dataRow)
        {

            this.TenNV = (string)dataRow["TenNV"];
            this.Username = (string)dataRow["username"];
            this.Password = (string)dataRow["pass"];
            this.TenLoai = (string)dataRow["TenLoai"];
            this.TrangThai = (int)dataRow["trangthai"];
        }
    }
}

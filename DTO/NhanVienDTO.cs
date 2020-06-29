using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class NhanVienDTO
    {

        private int ID;
        private string TenNV;
        private string SDT;
        private DateTime NgayVaoLam;
        private string Diachi;
<<<<<<< HEAD
        private string HinhAnh;
        private string ChucVu;
=======
        private string LoaiNV;
        private string HinhAnh;
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2


        public int ID1 { get => ID; set => ID = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
<<<<<<< HEAD
        public string NgayVaoLam1 { get => NgayVaoLam; set => NgayVaoLam = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Diachi1 { get => Diachi; set => Diachi = value; }
        public string HinhAnh1 { get => HinhAnh; set => HinhAnh = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }

        public NhanVienDTO (int id, string tenNV, string ngaySinh, string sdt, string ngayVaoLam, int trangThai,string chucvu,string hinhanh) 
=======
        public string SDT1 { get => SDT; set => SDT = value; }
        public DateTime NgayVaoLam1 { get => NgayVaoLam; set => NgayVaoLam = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string LoaiNV1 { get => LoaiNV; set => LoaiNV = value; }
        public string HinhAnh1 { get => HinhAnh; set => HinhAnh = value; }
        

        public NhanVienDTO (int id, string tenNV, string ngaySinh, string sdt, DateTime ngayVaoLam, int trangThai,string HinhAnh,string loaiNV) 
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
        {
            this.ID = id;
            this.TenNV = tenNV;
            this.SDT = sdt;
            this.NgayVaoLam = ngayVaoLam;
<<<<<<< HEAD
            this.ChucVu = chucvu;
            this.HinhAnh = hinhanh;
=======
            this.LoaiNV = loaiNV;
            this.HinhAnh = HinhAnh;
          
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
        }
        public NhanVienDTO(DataRow dataRow)
        {
            this.ID = (int)dataRow["ID"];
            this.TenNV = (string)dataRow["TenNV"];
<<<<<<< HEAD
            this.NgayVaoLam = dataRow["NgayVaoLam"].ToString();
            this.SDT = (string)dataRow["SDT"];
            this.Diachi = (string)dataRow["diachi"];
            this.HinhAnh = (string)dataRow["HinhAnh"];
            this.ChucVu = (string)dataRow["ChucVu"];


=======
            this.SDT = (string)dataRow["SDT"];
            this.NgayVaoLam = Convert.ToDateTime(dataRow["NgayVaoLam"]);
            this.Diachi = (string)dataRow["diachi"];
            this.LoaiNV = (string)dataRow["TenLoai"];
            this.HinhAnh = (string)dataRow["HinhAnh"];
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
        }
    }
}

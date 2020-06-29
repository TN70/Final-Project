using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DoanhThuDTO
    {
       private int MaSP;
       private string TenSP;
       private int SoLuong;
       private float Gia;
       private float GiamGia;
       private float TongTien;

        public int MaSP1 { get => MaSP; set => MaSP = value; }
        public string TenSP1 { get => TenSP; set => TenSP = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float Gia1 { get => Gia; set => Gia = value; }
        public float GiamGia1 { get => GiamGia; set => GiamGia = value; }
        public float TongTien1 { get => TongTien; set => TongTien = value; }

        public DoanhThuDTO(int masp, string tensp, int soluong, float gia, float giamgia)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.SoLuong = soluong;
            this.Gia = gia;
            this.GiamGia = giamgia;
        }
        public DoanhThuDTO(DataRow dataRow)
        {
            this.TenSP = (string)dataRow["TenMenu"];
            this.Gia = float.Parse(dataRow["GiaBan"].ToString());
            this.GiamGia = (float)double.Parse(dataRow["GiamGia"].ToString());
            this.SoLuong = (int)dataRow["SoLuong"];
            this.TongTien = (this.SoLuong * this.Gia) - ((this.SoLuong * this.Gia) * this.GiamGia);
        }
    }
}

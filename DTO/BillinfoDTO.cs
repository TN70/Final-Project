using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class BillInfoDTO
    {
        string tenMenu;

        public string TenMenu { get => tenMenu; set => tenMenu = value; }
        public float GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        public BillInfoDTO()
        {

        }
        public BillInfoDTO(DataRow dr)
        {

            this.TenMenu = dr["TenMenu"].ToString();
            this.GiaBan =(float) Convert.ToDouble(dr["GiaBan"].ToString());
            this.SoLuong = (int)dr["SoLuong"];
            this.ThanhTien= (float)Convert.ToDouble(dr["ThanhTien"].ToString());

        }
        float giaBan;
        int soLuong;
        float thanhTien;
    }
}

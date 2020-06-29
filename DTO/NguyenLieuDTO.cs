using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieuDTO
    {
        private int ID;
        private string TenNL;
        private string DVT;
        private float DonGia;
        private float SLTon;

        public int ID1 { get => ID; set => ID = value; }
        public string TenNL1 { get => TenNL; set => TenNL = value; }
        public string DVT1 { get => DVT; set => DVT = value; }
        public float DonGia1 { get => DonGia; set => DonGia = value; }
        public float SLTon1 { get => SLTon; set => SLTon = value; }

        public NguyenLieuDTO(int id, string tenNL, string dvt, float donGia, float SLTon)
        {
            this.ID = id;
            this.TenNL = tenNL;
            this.DVT = dvt;
            this.DonGia = donGia;
            this.SLTon = SLTon;
        }
        public NguyenLieuDTO(DataRow dataRow)
        {
            this.ID = (int)dataRow["ID"];
            this.TenNL = (string)dataRow["TenNL"];
            this.DVT = (string)dataRow["DVT"];
            this.DonGia = float.Parse(dataRow["DonGia"].ToString());
            this.SLTon = float.Parse(dataRow["SLTon"].ToString());
        } 
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        private string maProduct;
        private string tenSp;
        private  int  donGia1;
        private string donVi;

        public string MaProduct { get => maProduct; set => maProduct = value; }
        public string TenSp { get => tenSp; set => tenSp = value; }
        public int  DonGia1 { get => donGia1; set => donGia1 = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public ProductDTO(string ma,string ten,int gia,string donvi)
        {
            this.MaProduct = ma;
            this.TenSp = ten;
            this.DonGia1 = gia;
            this.DonVi = donvi;
        }
        public ProductDTO(DataRow item)
        {
            this.MaProduct = (string)item["MaThucUong"];
            this.TenSp =(string) item["TenThucUong"];
            this.DonGia1 = (int)item["DonGia"];
            this.DonVi = (string)item["DVT"];
        }
    }
}

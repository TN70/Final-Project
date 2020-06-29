using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TableDTO
    {
        public TableDTO(string maBan, int soghe, int trangthai, int tinhtrang)
        {
            this.IMaBan = maBan;
            this.ISoGhe = soghe;
            this.ITrangThai = trangthai;
            this.ITinhTrang = tinhtrang;
        }
        public TableDTO(DataRow dataRow )
        {
            int SoBan = (int)dataRow["ID"];
            if(SoBan < 10)
            {
                this.IMaBan = "BAN00" + SoBan;
            } else if(SoBan < 100)
            {
                this.IMaBan = "BAN0" + SoBan;
            } else
            {
                this.IMaBan = "BAN" + SoBan;
            }
            
            this.ISoGhe = (int)dataRow["SoGhe"];
            this.ITrangThai = (int)dataRow["TrangThai"];
            this.iTinhTrang = (int)dataRow["TinhTrang"];
        }
        public TableDTO(DataRow dataRow, int q )
        {
            int SoBan = (int)dataRow["ID"];
            iMaBan = SoBan + "";

            this.ISoGhe = (int)dataRow["SoGhe"];
            this.ITrangThai = (int)dataRow["TrangThai"];
            this.iTinhTrang = (int)dataRow["TinhTrang"];
        }
        private string iMaBan;
        private int iSoGhe;
        private int iTrangThai;
        private int iTinhTrang;

        public string IMaBan { get => iMaBan; set => iMaBan = value; }
        public int ISoGhe { get => iSoGhe; set => iSoGhe = value; }
        public int ITrangThai { get => iTrangThai; set => iTrangThai = value; }
        public int ITinhTrang { get => iTinhTrang; set => iTinhTrang = value; }
    }
}

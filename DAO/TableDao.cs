using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class TableDao
    {
        private static TableDao instance;
        QuanLyQuanCaFeEntities _qlcfEf = new QuanLyQuanCaFeEntities();
        int ChangeMaban(string maBan)
        {
            string ma = maBan.Substring(3);

            int soBan = Convert.ToInt32(ma);
            return soBan;
        }
        public static TableDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDao();
                return instance;
            }
            private set { TableDao.instance = value; }
        }
        private  TableDao()
        {

        }
        
        public int InsertBan(int soGhe, int trangThai, int tinhTrang)
        {
            string query = string.Format("insert ban(SoGhe,TrangThai,TinhTrang) values('{0}','{1}','{2}')",soGhe,trangThai,tinhTrang);
            int resutl = DataProvider.Instance.ExecuteNonQuery(query);
            if (resutl > 0)
                return 1;
            else
                return 0;

        }
        public List<TableDTO> LoadListTable()
        {
            string execGetBan = "select * from Ban";
            List<TableDTO> list = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(execGetBan);
            foreach (DataRow row in data.Rows)
            {
                TableDTO item = new TableDTO(row);
                list.Add(item);
            }
            return list;
        }
        public int update(int MaBan, int iTrangThai, int TinhTrang,int soghe)
        {
            string query = string.Format("update ban set TrangThai='{0}', TinhTrang='{1}', SoGhe='{2}' where ID='{3}'", iTrangThai, TinhTrang,soghe,MaBan);
            if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                return 1;
            else
                return 0;
        }
        public bool CapNhatBan(int MaBan, int iTrangThai)
        {
            try
            {
                BAN ban = new BAN();
                ban = _qlcfEf.BANs.SingleOrDefault(u => u.ID == MaBan);
                ban.TrangThai = iTrangThai;
                _qlcfEf.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public int upDateStatusBan(int MaBan,int iTrangThai)
        {
            string strSqlUpdate = "update Ban set trangthai={0} where Id='{1}'";
            string strInsert = string.Format(strSqlUpdate,iTrangThai,MaBan);


            int sqlCmd = DataProvider.Instance.ExecuteNonQuery(strInsert);

            return sqlCmd;

        }
        public List<TableDTO> LoadListTableNull()
        {
            string execGetBan = "select * from Ban where trangthai=0";
            List<TableDTO> list = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(execGetBan);
            foreach (DataRow row in data.Rows)
            {
              
                TableDTO item = new TableDTO(row,1);
                list.Add(item);
            }
            return list;
        }
        public List<TableDTO> listYeuCau(string cbo, string txt)
        {
            string query = "";
            if(cbo == "Mã bàn")
            {
                query = string.Format("select * from Ban where ID LIKE '%{0}%' ", txt);
            } 
            else if(cbo == "Số ghế")
            {
                query = string.Format("select * from Ban where SoGhe = '{0}' ", txt);
            }
            else if (cbo == "Trạng thái")
            {
                query = string.Format("select * from Ban where TrangThai = '{0}' ", txt);
            }
            else
            {
                query = string.Format("select * from Ban where TinhTrang = '{0}' ", txt);
            }

            List<TableDTO> list = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                TableDTO item = new TableDTO(row);
                list.Add(item);
            }
            return list;
        }
       

    }
}

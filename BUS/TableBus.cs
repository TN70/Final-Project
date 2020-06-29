using System;
using DAO;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TableBus
    {
        private static TableBus instance;

        private TableBus()
        {

        }

        public static TableBus Instance {
            get
            {
                if (instance == null)
                    instance = new TableBus();
                return instance;
            }
            private set { TableBus.instance = value; }
        }

        public List<TableDTO> LoadTable()
        {
            return TableDao.Instance.LoadListTable();
        }
        public int UpdateStatusBan(int strMaBan, int iTrangThai)
        {
            return TableDao.Instance.upDateStatusBan(strMaBan, iTrangThai);
        }
        public List<TableDTO> LoadListTableNull()
        {
            return TableDao.Instance.LoadListTableNull();
        }
        public int update(int MaBan, int iTrangThai,int tinhtrang,int soghe)
        {
            return TableDao.Instance.update(MaBan, iTrangThai,tinhtrang,soghe);
        }
        public int InsertBan(int soGhe, int trangThai , int tinhTrang )
        {
            return TableDao.Instance.InsertBan(soGhe, trangThai, tinhTrang);
        }
        public bool CapNhatBan(int MaBan, int iTrangThai)
        {
            return TableDao.Instance.CapNhatBan(MaBan, iTrangThai);
        }
        public List<TableDTO> listYeuCau(string cbo, string txt)
        {
            return TableDao.Instance.listYeuCau(cbo, txt);
        }
    }
}

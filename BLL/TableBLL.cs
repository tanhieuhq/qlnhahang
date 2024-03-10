using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class TableBLL
    {

        private static TableBLL instance;
        public static TableBLL Instance
        {
            get { if (instance == null) instance = new TableBLL(); return instance; }
            private set { TableBLL.instance = value; }
        }
        private TableBLL() { }


        public List<Table> LayDanhSachBan()
        {
            List<Table> tableList = TableDAL.Instance.LayDanhSachBan();
            return tableList;
        }

        public void ChuyenBan(int idBan1, int idBan2)
        {
            TableDAL.Instance.ChuyenBan(idBan1, idBan2);
        }

        public void GopBan(int idBan1, int idBan2)
        {
            TableDAL.Instance.GopBan(idBan1, idBan2);
        }

        public bool ThemBan(string tenBan)
        {
            return TableDAL.Instance.ThemBan(tenBan);
        }

        public bool SuaBan(string tenBan, string tinhtrang,int idBan)
        {
            return TableDAL.Instance.SuaBan(tenBan, tinhtrang, idBan);
        }

        public bool XoaBan(int idBan)
        {
            return TableDAL.Instance.XoaBan(idBan);
        }

        public List<Table> TimKiemBan(string tenBan)
        {
            return TableDAL.Instance.TimKiemBan(tenBan);
        }

    }
}

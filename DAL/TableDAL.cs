using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TableDAL
    {
        private static TableDAL instance;
        public static TableDAL Instance
        {
            get { if (instance == null) instance = new TableDAL(); return instance; }
            private set { instance = value; }
        }

        private TableDAL() { }

        public List<Table> LayDanhSachBan()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_LayDanhSachBan");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public void ChuyenBan(int idBan1, int idBan2)
        {
            DataProvider.Instance.ExecuteQuery("exec sp_ChuyenBan @id1 , @id2 ", new object[] { idBan1, idBan2 });
        }


        public void GopBan(int idBan1, int idBan2)
        {
            DataProvider.Instance.ExecuteQuery("exec sp_GopBan @id1 , @id2 ", new object[] { idBan1, idBan2 });
        }

        public bool ThemBan(string tenBan)
        {
            string query = string.Format("INSERT BAN(TenBan) VALUES(N'{0}')", tenBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaBan(string tenBan,string tinhtrang,int idBan)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_SuaBan @tenban , @tinhtrang , @idBan", new object[] { tenBan, tinhtrang,idBan });
            return result > 0;
        }

        public bool XoaBan(int idBan)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE Ban Set An=1 WHERE ID="+idBan);
            return result > 0;
        }

        public List<Table> TimKiemBan(string tenBan)
        {
            List<Table> tableList = new List<Table>();
            string query = string.Format("SELECT * FROM Ban WHERE dbo.fuConvertToUnsign1(TenBan) like '%'+ dbo.fuConvertToUnsign1(N'{0}')+'%' AND An=0", tenBan);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}

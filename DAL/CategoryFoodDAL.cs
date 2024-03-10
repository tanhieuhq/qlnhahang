using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class CategoryFoodDAL
    {
        private static CategoryFoodDAL instance;

        public static CategoryFoodDAL Instance
        {
            get { if (instance == null) instance = new CategoryFoodDAL(); return instance; }
            private set { instance = value; }
        }
        private CategoryFoodDAL() { }

        public List<CategoryFood> LayDSLoaiMon()
        {
            List<CategoryFood> list = new List<CategoryFood>();

            string query = "SELECT * FROM LoaiMon WHERE An=0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CategoryFood category = new CategoryFood(item);
                list.Add(category);
            }
            return list;
        }

        public CategoryFood LoaiMonTheoID(int idLoaiMon)
        {
            DataTable data =DataProvider.Instance.ExecuteQuery("SELECT * FROM LoaiMon WHERE ID=" + idLoaiMon);
            DataRow row = data.Rows[0];
            CategoryFood category = new CategoryFood(row);
            return category;
        }

        public bool TonTaiTenLoaiMon(string tenLoaiMon)
        {
            string query = string.Format("SELECT * FROM LoaiMon WHERE TenLoai=N'{0}'", tenLoaiMon);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool ThemLoaiMon(string tenLoaiMon)
        {
            string query = string.Format("INSERT LoaiMon(TenLoai) VALUES(N'{0}')", tenLoaiMon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool SuaLoaiMon(int idLoaiMon,string tenLoaiMon)
        {
            string query = string.Format("UPDATE LoaiMon SET TenLoai=N'{0}' WHERE ID={1}", tenLoaiMon,idLoaiMon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool XoaLoaiMon(int idLoaiMon)
        {
            string query = string.Format("UPDATE LoaiMon SET An=1 WHERE ID={0}",idLoaiMon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<CategoryFood> TimKiemLoaiMon(string tenLoai)
        {
            List<CategoryFood> list = new List<CategoryFood>();
            string query = string.Format("SELECT * FROM LoaiMon WHERE An=0 AND dbo.fuConvertToUnsign1(TenLoai) like '%'+ dbo.fuConvertToUnsign1(N'{0}')+'%'", tenLoai);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CategoryFood category = new CategoryFood(item);
                list.Add(category);
            }
            return list;
        }

    }
}

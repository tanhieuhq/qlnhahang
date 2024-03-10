using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class FoodDAL
    {
        private static FoodDAL instance;
        public static FoodDAL Instance
        {
            get { if (instance == null) instance = new FoodDAL(); return instance; }
            private set { instance = value; }
        }

        private FoodDAL() { }

        public DataTable DanhSachMon()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Mon.ID, TenMon, Gia,LoaiMon.TenLoai FROM Mon, LoaiMon WHERE Mon.LoaiMon=LoaiMon.ID AND Mon.An=0");
            return data;
        }

        public List<Food> DSMonTheoIDLoaiMon(int idLoaiMon)
        {
            List<Food> listFood = new List<Food>();
            string query = "SELECT * FROM Mon WHERE LoaiMon= " + idLoaiMon+" AND An=0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }
            return listFood;
        }

        public bool ThemMon(string tenMon, float gia, int idLoaiMon)
        {
            string query = string.Format("INSERT INTO Mon(tenMon,Gia,LoaiMon) VALUES(N'{0}',{1},{2})", tenMon, gia, idLoaiMon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool SuaMon(string tenMon, float gia, int idLoaiMon, int idMon)
        {
            string query = string.Format("UPDATE Mon SET TenMon=N'{0}', Gia={1},LoaiMon={2} WHERE ID={3}", tenMon, gia, idLoaiMon, idMon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool XoaMon(int idMon)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE Mon SET An=1 WHERE ID= " + idMon);
            return result > 0;
        }

        public DataTable TimKiemMon(string tenMon)
        {
            string query = string.Format("SELECT Mon.ID, TenMon, Gia,LoaiMon.TenLoai FROM Mon, LoaiMon WHERE Mon.LoaiMon=LoaiMon.ID AND Mon.An=0 AND dbo.fuConvertToUnsign1(TenMon) like '%'+ dbo.fuConvertToUnsign1(N'{0}')+'%'", tenMon);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}

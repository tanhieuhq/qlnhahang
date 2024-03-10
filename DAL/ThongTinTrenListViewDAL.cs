using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ThongTinTrenListViewDAL
    {
        private static ThongTinTrenListViewDAL instance;
        public static ThongTinTrenListViewDAL Instance
        {
            get { if (instance == null) instance = new ThongTinTrenListViewDAL(); return instance; }
            private set { instance = value; }

        }

        private ThongTinTrenListViewDAL() { }

        public List<ThongTinTrenListView> LayHoaDonTheoBan(int idBan)
        {
            List<ThongTinTrenListView> list = new List<ThongTinTrenListView>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SP_LayThongTinTrenListView @idBan", new object[] {idBan });
            foreach (DataRow item in data.Rows)
            {
                ThongTinTrenListView tttlv = new ThongTinTrenListView(item);
                list.Add(tttlv);
            }
            return list;
        }
    }
}

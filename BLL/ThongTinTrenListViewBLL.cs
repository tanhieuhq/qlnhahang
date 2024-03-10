using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ThongTinTrenListViewBLL
    {
        private static ThongTinTrenListViewBLL instance;
        public static ThongTinTrenListViewBLL Instance
        {
            get { if (instance == null) instance = new ThongTinTrenListViewBLL(); return instance; }
            private set { instance = value; }

        }

        private ThongTinTrenListViewBLL() { }

        public List<ThongTinTrenListView> LayHoaDonTheoBan(int idBan)
        {
            return ThongTinTrenListViewDAL.Instance.LayHoaDonTheoBan(idBan);
        }
    }
}

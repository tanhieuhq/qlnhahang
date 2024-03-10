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
    public class FoodBLL
    {
        private static FoodBLL instance;
        public static FoodBLL Instance
        {
            get { if (instance == null) instance = new FoodBLL(); return instance; }
            private set { instance = value; }
        }

        private FoodBLL() { }

        public DataTable DanhSachMon()
        {
            return FoodDAL.Instance.DanhSachMon();
        }

        public List<Food> DSMonTheoIDLoaiMon(int idLoaiMon)
        {
            return FoodDAL.Instance.DSMonTheoIDLoaiMon(idLoaiMon);
        }

        public bool ThemMon(string tenMon, float gia, int idLoaiMon)
        {
            return FoodDAL.Instance.ThemMon(tenMon, gia, idLoaiMon);
        }
        public bool SuaMon(string tenMon, float gia, int idLoaiMon, int idMon)
        {
            return FoodDAL.Instance.SuaMon(tenMon, gia, idLoaiMon, idMon);
        }

        public bool XoaMon(int idMon)
        {
            return FoodDAL.Instance.XoaMon(idMon);
        }

        public DataTable TimKiemMon(string tenMon)
        {
            return FoodDAL.Instance.TimKiemMon(tenMon);
        }
    }
}

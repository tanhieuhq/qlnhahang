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
    public class CategoryFoodBLL
    {
        private static CategoryFoodBLL instance;

        public static CategoryFoodBLL Instance
        {
            get { if (instance == null) instance = new CategoryFoodBLL(); return instance; }
            private set { instance = value; }
        }
        private CategoryFoodBLL() { }

        public List<CategoryFood> LayDSLoaiMon()
        {
            return CategoryFoodDAL.Instance.LayDSLoaiMon();
        }

        public CategoryFood LoaiMonTheoID(int idLoaiMon)
        {
            return CategoryFoodDAL.Instance.LoaiMonTheoID(idLoaiMon);
        }

        public bool TonTaiTenLoaiMon(string tenLoaiMon)
        {
            return CategoryFoodDAL.Instance.TonTaiTenLoaiMon(tenLoaiMon);
        }

        public bool ThemLoaiMon(string tenLoaiMon)
        {
            return CategoryFoodDAL.Instance.ThemLoaiMon(tenLoaiMon);
        }

        public bool SuaLoaiMon(int idLoaiMon, string tenLoaiMon)
        {
            return CategoryFoodDAL.Instance.SuaLoaiMon(idLoaiMon, tenLoaiMon);
        }

        public bool XoaLoaiMon(int idLoaiMon)
        {
            return CategoryFoodDAL.Instance.XoaLoaiMon(idLoaiMon);
        }

        public List<CategoryFood> TimKiemLoaiMon(string tenLoai)
        {
            return CategoryFoodDAL.Instance.TimKiemLoaiMon(tenLoai);
        }


    }
}

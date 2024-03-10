using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BillInfoBLL
    {
        private static BillInfoBLL instance;
        public static BillInfoBLL Instance
        {
            get { if (BillInfoBLL.instance == null) instance = new BillInfoBLL(); return BillInfoBLL.instance; }
            private set { BillInfoBLL.instance = value; }
        }
        private BillInfoBLL() { }

        public void ThemChiTietHoaDon(int idHoaDon, int idMon, int SoLuong)
        {
            BillInfoDAL.Instance.ThemChiTietHoaDon(idHoaDon, idMon, SoLuong);
        }

        public void CapNhatPhieuGoiMon(int idCTHoaDon, int soLuong)
        {
            BillInfoDAL.Instance.CapNhatPhieuGoiMon(idCTHoaDon, soLuong);
        }

        public void XoaPhieuGoiMon(int idCTHD)
        {
            BillInfoDAL.Instance.XoaPhieuGoiMon(idCTHD);
        }

        /*public List<BillInfo> LayDanhSachCTHDTheoIDHD(int idHoaDon)
        {
            return BillInfoDAL.Instance.LayDanhSachCTHDTheoIDHD(idHoaDon);
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance
        {
            get { if (BillInfoDAL.instance == null) instance = new BillInfoDAL(); return BillInfoDAL.instance; }
            private set { BillInfoDAL.instance = value; }
        }
        private BillInfoDAL() { }


        public void ThemChiTietHoaDon(int idHoaDon, int idMon, int SoLuong)
        {
            DataProvider.Instance.ExecuteQuery("EXEC SP_ThemChiTietHoaDon @idBan , @idMon , @SoLuong", new object[] { idHoaDon, idMon, SoLuong });
        }


        public int KiemTraCTHoaDonTheoIDHD(int idHoaDon, int idMon)
        {
            if (DataProvider.Instance.ExecuteScalar("SELECT * FROM ChiTietHoaDon WHERE idHoaDon = " + idHoaDon + " AND idMon= "+ idMon) == null)
                return 0;
            else
                return 1;

        }

        public void CapNhatPhieuGoiMon(int idCTHoaDon,int soLuong)
        {
            DataProvider.Instance.ExecuteNonQuery("exec SP_CapNhatChiTietHoaDon @idCTHoaDon , @soLuong", new object[] { idCTHoaDon, soLuong });
        }

        public void XoaPhieuGoiMon(int idCTHD)
        {
            DataProvider.Instance.ExecuteNonQuery("delete ChiTietHoaDon where ID=" + idCTHD);
        }

        /*public List<BillInfo> LayDanhSachCTHDTheoIDHD(int idHoaDon)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM ChiTietHoaDon WHERE idHoaDon= " + idHoaDon);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }*/
    }
}

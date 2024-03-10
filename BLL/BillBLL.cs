using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BillBLL
    {
        private static BillBLL instance;
        public static BillBLL Instance
        {
            get { if (BillBLL.instance == null) instance = new BillBLL(); return BillBLL.instance; }
            private set { BillBLL.instance = value; }
        }
        private BillBLL() { }

        public void ThemHoaDon(int idBan, int idTaiKhoan)
        {
            BillDAL.Instance.ThemHoaDon(idBan, idTaiKhoan);
        }

        public int LayIDHoaDonTheoIDBan(int idBan)
        {
            return BillDAL.Instance.LayIDHoaDonTheoIDBanChuaThanhToan(idBan);

        }

        public int IdHoaDonLonNhat()
        {
            return BillDAL.Instance.IdHoaDonLonNhat();
        }

        public void ThanhToan(int idBill, int KhuyenMai,float tongTien)
        {
            BillDAL.Instance.ThanhToan(idBill,KhuyenMai, tongTien);
        }

        public int KiemTraCTHoaDonTheoIDHD(int idHoaDon, int idMon)
        {
            return BillInfoDAL.Instance.KiemTraCTHoaDonTheoIDHD(idHoaDon, idMon);
        }

        public DataTable ThongKeHoaDon(DateTime ngayTao, DateTime ngayThanhToan)
        {
            return BillDAL.Instance.ThongKeHoaDon(ngayTao.Date, ngayThanhToan.Date);
        }

        public int HoaDonChuaThanhToan()
        {
            return BillDAL.Instance.HoaDonChuaThanhToan();
        }

        public DataTable CTHDTheoHD(int idHD)
        {
            return BillDAL.Instance.CTHDTheoHD(idHD);
        }

        public DataTable HoaDonTheoNgayVaTrang(DateTime ngayTao, DateTime ngayThanhToan, int soTrangHienTai)
        {
            return BillDAL.Instance.HoaDonTheoNgayVaTrang(ngayTao, ngayThanhToan, soTrangHienTai);
        }

        public DataTable HoaDonTheoNgayVaTrangTK(DateTime ngayTao, DateTime ngayThanhToan, int soTrangHienTai,int idTK)
        {
            return BillDAL.Instance.HoaDonTheoNgayVaTrangTK(ngayTao, ngayThanhToan, soTrangHienTai,idTK);
        }

        public int SoLuongHoaDonTheoNgay(DateTime ngayTao, DateTime ngayThanhToan)
        {
            return BillDAL.Instance.SoLuongHoaDonTheoNgay(ngayTao, ngayThanhToan);
        }


        public HoaDonReport HoaDonReport(int idHD)
        {
            return BillDAL.Instance.HoaDonReport(idHD);
        }
    }
}

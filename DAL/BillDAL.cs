using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class BillDAL
    {
        private static BillDAL instance;
        public static BillDAL Instance
        {
            get { if (BillDAL.instance == null) instance = new BillDAL(); return BillDAL.instance; }
            private set { BillDAL.instance = value; }
        }

        private BillDAL() { }


        public int LayIDHoaDonTheoIDBanChuaThanhToan(int idBan)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE idBan=" + idBan + " AND TinhTrang=0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void ThemHoaDon(int idBan, int idTaiKhoan)
        {
            DataProvider.Instance.ExecuteQuery("EXEC SP_ThemHoaDon @idBan , @idTaiKhoan", new object[] { idBan, idTaiKhoan });
        }

        public int IdHoaDonLonNhat()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM HoaDon");
            }
            catch
            {
                return 1;
            }
        }

        public void ThanhToan(int idHoaDon, int KhuyenMai,float tongTien)
        {
            string query = "UPDATE HoaDon SET NgayThanhToan=GETDATE(), TinhTrang=1, KhuyenMai = "+ KhuyenMai +", TongTien="+tongTien+" WHERE id= "+ idHoaDon;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable ThongKeHoaDon(DateTime ngayTao, DateTime ngayThanhToan)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC SP_ThongKeHoaDon @ngayTao , @ngayThanhToan", new object[] { ngayTao, ngayThanhToan });
        }

        public int HoaDonChuaThanhToan()
        {
            object data = DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM HoaDon WHERE TinhTrang=0");
            return(int)data;
        }

        public DataTable CTHDTheoHD(int idHD)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC SP_CTHDTheoHD @idHD",new object[] { idHD});
        }

        public DataTable HoaDonTheoNgayVaTrang(DateTime ngayTao,DateTime ngayThanhToan,int soTrangHienTai)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC SP_HoaDonTheoNgayVaTrang @ngaytao , @ngaythanhtoan , @sotranghientai", new object[] { ngayTao, ngayThanhToan, soTrangHienTai });
        }

        public DataTable HoaDonTheoNgayVaTrangTK(DateTime ngayTao, DateTime ngayThanhToan, int soTrangHienTai,int idTK)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC SP_HoaDonTheoNgayVaTrangTK @ngaytao , @ngaythanhtoan , @sotranghientai , @idTK", new object[] { ngayTao, ngayThanhToan, soTrangHienTai,idTK });
        }


        public int SoLuongHoaDonTheoNgay(DateTime ngayTao, DateTime ngayThanhToan)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC SP_SoLuongHoaDonTheoNgay @ngaytao , @ngaythanhtoan", new object[] { ngayTao, ngayThanhToan });
        }

        public HoaDonReport HoaDonReport(int idHD)
        {
            DataTable data= DataProvider.Instance.ExecuteQuery("EXEC SP_HoaDonReport @idHD", new object[] { idHD });
            HoaDonReport hoaDonReport = new HoaDonReport(data.Rows[0]);
            return hoaDonReport;
        }
    }
}

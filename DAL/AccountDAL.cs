using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class AccountDAL
    {
        
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { AccountDAL.instance = value; }
        }
        private AccountDAL() { }

        public Account DangNhap(string username, string password)
        {
            string query = "SP_DangNhap @TenDangNhap , @MatKhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            foreach (DataRow item in result.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public DataTable DSTaiKhoan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TaiKhoan.ID,TenTaikhoan,TenHienThi,DiaChi,SDT,LoaiTaiKhoan,TenLoaiTK FROM TaiKhoan, LoaiTaiKhoan WHERE TaiKhoan.LoaiTaiKhoan=LoaiTaiKhoan.ID AND An=0");
        }

        public Account LayTaiKhoanTheoID(int idTK)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TaiKhoan WHERE ID= " + idTK +" AND An=0");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool LayTenTaiKhoan(string tenTK)
        {
            int result = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan=N'" + tenTK+"'");
            return result> 0;
        }

        public bool CapNhatThongTinTK(int id, string hoTen, string diaChi, string sDT, string password)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE TaiKhoan SET TenHienThi= N'" + hoTen + "', DiaChi= N'" + diaChi + "', SDT= " + sDT + " WHERE ID= " + id + " AND MatKhau= '" + password+"'");
            return result > 0;
        }

        public bool DoiMatKhauTK(int id, string password, string newPassword)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE TaiKhoan SET MatKhau= N'" + newPassword + "' WHERE ID= " + id + " AND MatKhau= '" + password + "'");
            return result > 0;
        }

        public bool ThemTaiKhoan(string tenTK, string tenHienThi, string diaChi, string SDT, int loaiTK)
        {
            string query = string.Format("INSERT INTO TaiKhoan(TenTaikhoan, MatKhau, TenHienThi,DiaChi,SDT,LoaiTaiKhoan) VALUES('{0}',N'1366812445212119514883209215136661110628', N'{1}', N'{2}','{3}',{4})", tenTK,tenHienThi,diaChi,SDT,loaiTK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool SuaTaiKhoan(string tenTK, int loaiTK, int maTK)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_SuaTaiKhoan @tenTK , @loaiTk , @idTK",new object[] {tenTK,loaiTK,maTK});
            return result > 0;
        }

        public bool SuaTTCaNhan(int maTK, string hoTen, string diaChi,string SDT)
        {
            string query = string.Format("UPDATE TaiKhoan SET TenHienThi=N'{0}',DiaChi=N'{1}', SDT='{2}' WHERE ID={3}", hoTen, diaChi,SDT, maTK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool XoaTaiKhoan(int maTK)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE TaiKhoan SET An=1 WHERE ID= " + maTK);
            return result > 0;
        }

        public bool DatLaiMatKhau(int maTK)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE TaiKhoan SET MatKhau=N'1366812445212119514883209215136661110628' WHERE ID= " + maTK);
            return result > 0;
        }

        public DataTable TimKiemTaiKhoan(string hoten)
        {
            string query = string.Format("SELECT TaiKhoan.ID,TenTaikhoan,TenHienThi,DiaChi,SDT,LoaiTaiKhoan,TenLoaiTK FROM TaiKhoan, LoaiTaiKhoan WHERE TaiKhoan.LoaiTaiKhoan=LoaiTaiKhoan.ID AND dbo.fuConvertToUnsign1(TenHienThi) like '%'+ dbo.fuConvertToUnsign1(N'{0}')+'%' AND An=0", hoten);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}

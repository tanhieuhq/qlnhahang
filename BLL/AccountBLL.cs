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
    public class AccountBLL
    {
        private static AccountBLL instance;
        public static AccountBLL Instance
        {
            get { if (instance == null) instance = new AccountBLL(); return instance; }
            private set { AccountBLL.instance = value; }
        }
        private AccountBLL() { }

        public Account DangNhap(string username, string password)
        {
            return AccountDAL.Instance.DangNhap(username, password);
             
        }
        public DataTable DSTaiKhoan()
        {
            return AccountDAL.Instance.DSTaiKhoan();
        }

        public Account LayTaiKhoanTheoID(int idTK)
        {
            return AccountDAL.Instance.LayTaiKhoanTheoID(idTK);
        }

        public bool LayTenTaiKhoan(string tenTK)
        {
            return AccountDAL.Instance.LayTenTaiKhoan(tenTK);
        }

        public bool CapNhatThongTinTK(int id, string hoTen, string diaChi, string sDT, string password)
        {
            return AccountDAL.Instance.CapNhatThongTinTK(id, hoTen, diaChi, sDT, password);
        }
        public bool DoiMatKhauTK(int id, string password, string newPassword)
        {
            return AccountDAL.Instance.DoiMatKhauTK(id, password, newPassword);
        }

        public bool ThemTaiKhoan(string tenTK, string tenHienThi, string diaChi, string SDT, int loaiTK)
        {
            return AccountDAL.Instance.ThemTaiKhoan(tenTK,tenHienThi,diaChi,SDT,loaiTK);
        }

        public bool SuaTaiKhoan(string tenTK, int loaiTK, int maTK)
        {
            return AccountDAL.Instance.SuaTaiKhoan(tenTK, loaiTK, maTK);
        }

        public bool SuaTTCaNhan(int maTK, string hoTen, string diaChi, string SDT)
        {
            return AccountDAL.Instance.SuaTTCaNhan(maTK, hoTen, diaChi, SDT);
        }

        public bool XoaTaiKhoan(int maTK)
        {
            return AccountDAL.Instance.XoaTaiKhoan(maTK);
        }

        public bool DatLaiMatKhau(int maTK)
        {
            return AccountDAL.Instance.DatLaiMatKhau(maTK);
        }

        public DataTable TimKiemTaiKhoan(string hoten)
        {
            return AccountDAL.Instance.TimKiemTaiKhoan(hoten);
        }
    }
}

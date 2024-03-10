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
    public class AccountCategoryBLL
    {

        private static AccountCategoryBLL instance;
        public static AccountCategoryBLL Instance
        {
            get { if (instance == null) instance = new AccountCategoryBLL(); return instance; }
            private set { AccountCategoryBLL.instance = value; }
        }
        private AccountCategoryBLL() { }

        public DataTable DSLoaiTaiKhoan()
        {
            return AccountCategoryDAL.Instance.DSLoaiTaiKhoan();
        }
    }
}

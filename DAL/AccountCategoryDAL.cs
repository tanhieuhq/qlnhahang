using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class AccountCategoryDAL
    {
        private static AccountCategoryDAL instance;
        public static AccountCategoryDAL Instance
        {
            get { if (instance == null) instance = new AccountCategoryDAL(); return instance; }
            private set { AccountCategoryDAL.instance = value; }
        }
        private AccountCategoryDAL() { }

        public DataTable DSLoaiTaiKhoan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM LoaiTaiKhoan");
        }
    }
}

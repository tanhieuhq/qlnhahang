using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountCategory
    {
        private int id;
        private string tenLoaiTK;

        public int Id { get => id; set => id = value; }
        public string TenLoaiTK { get => tenLoaiTK; set => tenLoaiTK = value; }

        public AccountCategory(int id, string tenLoaiTK)
        {
            Id = id;
            TenLoaiTK = tenLoaiTK;
        }

        public AccountCategory(DataRow row)
        {
            Id = (int)row["ID"];
            TenLoaiTK = row["TenLoaiTK"].ToString();
        }

    }
}

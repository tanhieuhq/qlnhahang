using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private int id;
        private string userName;
        private string displayName;
        private string address;
        private string phoneNumber;
        private int type;
        

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type; set => type = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Account() { }

        public Account(int id, string userName, string displayName,string diaChi,string sDT, int type)
        {
            Id = id;
            UserName = userName;
            DisplayName = displayName;
            Address = diaChi;
            PhoneNumber = sDT;
            Type = type;
        }

        public Account(DataRow row)
        {
            Id = (int)row["ID"];
            UserName = row["TenTaiKhoan"].ToString();
            DisplayName = row["TenHienThi"].ToString();
            Address = row["DiaChi"].ToString();
            PhoneNumber = row["SDT"].ToString();
            Type = (int)row["LoaiTaiKhoan"];
        }

    }
}

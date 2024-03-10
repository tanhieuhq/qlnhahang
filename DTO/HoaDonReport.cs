using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonReport
    {
        private int iD;
        private string displayName;
        private string tableName;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private byte discount;
        private float totalPrice;

        public int ID { get => iD; set => iD = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public byte Discount { get => discount; set => discount = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public HoaDonReport(int iD, string displayName, string tableName, DateTime? dateCheckIn, DateTime? dateCheckOut, byte discount, float totalPrice)
        {
            ID = iD;
            DisplayName = displayName;
            TableName = tableName;
            DateCheckIn = dateCheckIn;
            DateCheckOut = dateCheckOut;
            Discount = discount;
            TotalPrice = totalPrice;
        }

        public HoaDonReport()
        {
        }

        public HoaDonReport(DataRow row)
        {
            this.ID = (int)row["SoHoaDon"];
            this.DisplayName = row["NguoiXuatHD"].ToString();
            this.TableName = row["TenBan"].ToString();
            this.DateCheckIn = (DateTime?)row["NgayTao"];
            var dateCheckOutTemp = row["NgayThanhToan"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            if (row["KhuyenMai"].ToString() != "")
                this.discount = Convert.ToByte(row["KhuyenMai"]);
            this.TotalPrice = (float)Convert.ToDouble(row["TongTien"]);
        }
    }
}

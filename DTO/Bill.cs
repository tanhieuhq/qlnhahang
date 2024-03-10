using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private byte status;
        private byte discount;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public byte Status { get => status; set => status = value; }
        public byte Discount { get => discount; set => discount = value; }

        public Bill(int iD, DateTime? dateCheckIn, DateTime? dateCheckOut, byte status, byte discount)
        {
            this.iD = iD;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.status = status;
            this.discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.DateCheckIn = (DateTime?)row["NgayTao"];
            var dateCheckOutTemp = row["NgayThanhToan"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.Status = Convert.ToByte( row["TinhTrang"]);
            if (row["KhuyenMai"].ToString() != "")
                this.discount = Convert.ToByte(row["KhuyenMai"]);
        }
    }
}

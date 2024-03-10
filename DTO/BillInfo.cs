using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInfo
    {
        private int iD;
        private int idFood;
        private int idBill;
        private int count;
        private float DonGia;

        public int ID { get => iD; set => iD = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int Count { get => count; set => count = value; }
        public float GiaBan { get => DonGia; set => DonGia = value; }

        public BillInfo(int iD, int idFood, int idBill, int count, float giaBan)
        {
            this.iD = iD;
            this.idFood = idFood;
            this.idBill = idBill;
            this.count = count;
            this.DonGia = giaBan;
        }

        public BillInfo(DataRow row)
        {
            ID = (int)row["ID"];
            IdBill = (int)row["idHoaDon"];
            IdFood = (int)row["idMon"];
            Count = (int)row["SoLuong"];
            GiaBan = (float)Convert.ToDouble(row["GiaBan"].ToString());
        }
    }
}

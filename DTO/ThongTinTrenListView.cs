using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinTrenListView
    {
        private int iD;
        private string foodName;
        private string tenLoaiMon;
        private int count;
        private float price;
        private float totalPrice;

        public int ID { get => iD; set => iD = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public string TenLoaiMon { get => tenLoaiMon; set => tenLoaiMon = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public ThongTinTrenListView(int id,string foodName,string tenLoaiMon, int count, float price, float totalPrice)
        {
            this.iD = id;
            this.foodName = foodName;
            this.tenLoaiMon = tenLoaiMon;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
        }

        public ThongTinTrenListView(DataRow row)
        {
            ID = (int)row["ID"];
            FoodName = row["TenMon"].ToString();
            TenLoaiMon = row["TenLoai"].ToString();
            Count = (int)row["SoLuong"];
            Price = (float)Convert.ToDouble((row["DonGia"]).ToString());
            TotalPrice = (float)Convert.ToDouble((row["TongTien"]).ToString());
        }
    }
}

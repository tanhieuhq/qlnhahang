using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Food
    {
        private int iD;
        private string name;
        private int iDcategory;
        private float price;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IDcategory { get => iDcategory; set => iDcategory = value; }
        public float Price { get => price; set => price = value; }

        public Food(int iD, string ten, int iDcategory, float price)
        {
            this.ID = iD;
            this.Name = ten;
            this.IDcategory = iDcategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["TenMon"].ToString();
            IDcategory = (int)row["LoaiMon"];
            Price = (float)Convert.ToDouble(row["Gia"].ToString());
        }
    }
}

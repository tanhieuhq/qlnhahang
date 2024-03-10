using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryFood
    {
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        public CategoryFood(int iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }

        public CategoryFood(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["TenLoai"].ToString();
        }
    }
}

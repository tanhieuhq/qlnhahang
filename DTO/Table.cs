using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Table
    {
        private int iD;
        private string name;
        private string status;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }


        public Table() { }

        public Table(int iD, string name, string status, byte isDelete)
        {
            ID = iD;
            Name = name;
            Status = status;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["TenBan"].ToString();
            this.Status = row["TinhTrang"].ToString();
        }


    }
}

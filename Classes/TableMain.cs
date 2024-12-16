using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_DB.Classes
{
    internal class TableMain
    {
        public string Id;
        public string Name;
        public double Price;
        public int Number;
        public double AllPrice;

        public TableMain(string id, string name, double price, int number, double allPrice)
        {
            Id = id;
            Name = name;
            Price = price;
            Number = number;
            AllPrice = allPrice;
        }

        public TableMain(string id) 
        {
            Id = id;
            Name = "";
            Price = 0;
            Number = 0;
            AllPrice = 0;
        }

    }
}

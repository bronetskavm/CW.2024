using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_DB.Classes
{
    internal class Zvits
    {
        public string DateId;
        public string ProductId;
        public string ProductName;
        public int Numbers;
        public double Price;
        public double AllPrice;
        public int AccountId;

        public Zvits(string dateId, string productId, string productName, int numbers, double price, double allPrice, int accountId)
        {
            DateId = dateId;
            ProductId = productId;
            ProductName = productName;
            Numbers = numbers;
            Price = price;
            AllPrice = allPrice;
            AccountId = accountId;
        }
    }
}

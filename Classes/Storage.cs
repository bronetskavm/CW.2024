using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_DB.Classes
{
    internal class Storage
    {
        public string Id;
        public string Name;
        public int Number;
        public double Price;
        public double AllPrice;
        public string ExpirationDate;
        public int ProviderId;
        public int DeliveryId;

        public Storage(string id, string name, int number, double price, double allprice, string expirationDate, int providerId, int deliveryId)
        {
            Id = id;
            Name = name;
            Number = number;
            Price = price;
            AllPrice = allprice;
            ExpirationDate = expirationDate;
            ProviderId = providerId;
            DeliveryId = deliveryId;
        }
    }
}

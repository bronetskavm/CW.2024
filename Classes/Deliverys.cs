using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_DB.Classes
{
    internal class Deliverys
    {
        public int Id;
        public string ProductID;
        public string NameProduct;
        public int Numbers;
        public double PricePiece;
        public double AllPrice;
        public string Arrival;
        public int ProviderId;

        public Deliverys(int id, string productId, string nameProduct, int numbers, double pricePiece, double allPrice, string arrival, int providerId)
        {
            Id = id;
            ProductID = productId;
            NameProduct = nameProduct;
            Numbers = numbers;
            PricePiece = pricePiece;
            AllPrice = allPrice;
            Arrival = arrival;
            ProviderId = providerId;
        }
    }
}

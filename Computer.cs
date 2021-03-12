using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTrackingSystem
{
    public class Computer
    {
        public Computer()
        {

        }
        public Computer(string purchaseDate, string price, string modelName)
        {
            PurchaseDate = purchaseDate;
            Price = price;
            ModelName = modelName;
        }

        public string PurchaseDate { get; set; }
        public string Price { get; set; }
        public string ModelName { get; set; }
    }
}

using System;

namespace AssetTrackingSystem
{
    public class Computers : Assets
    {
        public Computers(string category, DateTime purchaseDate, string modelName, int price)
        {
            Category = category;
            PurchaseDate = purchaseDate;
            ModelName = modelName;
            Price = price;
        }
    }
}

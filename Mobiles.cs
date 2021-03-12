using System;

namespace AssetTrackingSystem
{
    public class Mobiles : Assets
    {
        public Mobiles(string category, DateTime purchaseDate, string modelName, int price)
        {
            Category = category;
            PurchaseDate = purchaseDate;
            ModelName = modelName;
            Price = price;
        }
    }
}

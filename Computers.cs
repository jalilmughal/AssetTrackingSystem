namespace AssetTrackingSystem
{
    public class Computers : Assets
    {
        public Computers()
        {

        }
        public Computers(string category, string purchaseDate, string modelName, int price)
        {
            Category = category;
            PurchaseDate = purchaseDate;
            ModelName = modelName;
            Price = price;
        }
    }
}

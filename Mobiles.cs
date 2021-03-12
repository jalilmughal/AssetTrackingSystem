namespace AssetTrackingSystem
{
    public class Mobiles : Assets
    {
        public Mobiles()
        {

        }
        public Mobiles(string category, string purchaseDate, string modelName, int price)
        {
            Category = category;
            PurchaseDate = purchaseDate;
            ModelName = modelName;
            Price = price;
        }
    }
}

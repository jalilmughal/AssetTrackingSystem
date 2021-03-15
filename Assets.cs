using System;

namespace AssetTrackingSystem
{
    public class Assets
    {
        public string Category { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string ModelName { get; set; }
        public int Price { get; set; }
        public void AskForCategory(string input)
        {
            Console.Write("Category: ");
            input = Console.ReadLine();
        }
        public void AskForPurchaseDate(DateTime input)
        {
            Console.Write("Purchase Date: ");
            input = Convert.ToDateTime(Console.ReadLine());
        }
        public void AskForModelName(string input)
        {
            Console.Write("Model: ");
        }
        public void AskForPrice(int input)
        {
            Console.Write("Price: ");
        }
    }
}

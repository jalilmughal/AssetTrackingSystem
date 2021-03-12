using System;
using System.Collections.Generic;

namespace AssetTrackingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Assets assets = new Assets();
            //Check check = new Check();
            Computers computers = new Computers();
            Mobiles mobiles = new Mobiles();

            List<Assets> computerAssets = new List<Assets>();
            List<Assets> mobileAssets = new List<Assets>();

            string _Category = assets.Category;
            string _PurchaseDate = assets.PurchaseDate;
            string _ModelName = assets.ModelName;
            int _Price = assets.Price;

            Console.WriteLine("Type your product details bellow, exit by typing 'exit'!");

            do
            {
                //Input Category of the asset
                Console.Write("Category: 'Laptop' or 'Mobiles' ");
                _Category = Console.ReadLine();
                if (_Category.ToLower().Trim() == "exit")
                {
                    WriterExtensions.WriteMessageInRed("App'en stänges nu!");
                    break;
                }

                //Input PurchaseDate of the asset
                Console.Write("Purchase Date: ");
                _PurchaseDate = Console.ReadLine();

                if (_PurchaseDate.ToLower().Trim() == "exit")
                {
                    WriterExtensions.WriteMessageInRed("App'en stänges nu!");
                    break;
                }

                //Input ModelName of the asset
                Console.Write("Model Name: ");
                _ModelName = Console.ReadLine();
                if (_ModelName.ToLower().Trim() == "exit")
                {
                    WriterExtensions.WriteMessageInRed("App'en stänges nu!");
                    break;
                }

                //Input price of the asset
                Console.Write("Price: ");
                _Price = Convert.ToInt32(Console.ReadLine());
                if ((_Price).ToString().ToLower().Trim() == "exit")
                {
                    WriterExtensions.WriteMessageInRed("App'en stänges nu!");
                    break;
                }

                //if-loop, if the _Category=laptop then add the asset in computerAssets-List else add in mobileAssets-List.
                if (_Category.ToLower().Trim() == "laptop")
                {
                    computerAssets.Add(new Computers(_Category, _PurchaseDate, _ModelName, Convert.ToInt32(_Price)));
                }
                else
                {
                    mobileAssets.Add(new Mobiles(_Category, _PurchaseDate, _ModelName, Convert.ToInt32(_Price)));
                }
            } while (true);

            Console.WriteLine("Category".PadRight(15) + "PurchaseDate".PadRight(15) + "ModelName".PadRight(15) + "Price".ToString().PadRight(15));
            for (int i = 0; i < computerAssets.Count; i++)
            {
                Console.WriteLine(computerAssets[i].Category.PadRight(15) + computerAssets[i].PurchaseDate.PadRight(15) + computerAssets[i].ModelName.PadRight(15) + (computerAssets[i].Price).ToString().PadRight(15));
            }

            foreach (var item in mobileAssets)
            {
                Console.WriteLine(item.Category.PadRight(15) + item.PurchaseDate.PadRight(15) + item.ModelName.PadRight(15) + item.Price.ToString().PadRight(15));
            }

            Console.ReadKey();
        }
    }

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

    public class Assets
    {
        public string Category { get; set; }
        public string PurchaseDate { get; set; }
        public string ModelName { get; set; }
        public int Price { get; set; }
    }

    public static class WriterExtensions
    {
        public static void WriteMessageInRed(string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(input);
            Console.ResetColor();
        }
        public static void WriteMessageYellow(string input)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ResetColor();
        }
    }
}

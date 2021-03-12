using System;
using System.Collections.Generic;
using System.Linq;

namespace AssetTrackingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Assets assets = new Assets();

            List<Assets> computerAssets = new List<Assets>();
            List<Assets> mobileAssets = new List<Assets>();

            string _Category = assets.Category;
            DateTime _PurchaseDate = assets.PurchaseDate;
            string _ModelName = assets.ModelName;
            int _Price = assets.Price;

            Console.WriteLine("Type your product details bellow, exit by typing 'exit'.");

            do
            {
                //Input Category of the asset
                Console.WriteLine("Type 'Laptop' for Laptop Computers and 'Mobile' for Mobile Phones!");
                Console.Write("Category: ");
                _Category = Console.ReadLine();
                if (_Category.ToLower().Trim() == "exit")
                {
                    WriterExtensions.WriteMessageInRed("App'en stänges nu!");
                    break;
                }

                //Input PurchaseDate of the asset
                Console.WriteLine("Please enter date in format DD/MM/YYYY!");
                Console.Write("Purchase Date: ");
                _PurchaseDate = Convert.ToDateTime(Console.ReadLine());
 
                //Input ModelName of the asset
                Console.Write("Model Name: ");
                _ModelName = Console.ReadLine();
                if (_ModelName.ToLower().Trim() == "exit")
                {
                    WriterExtensions.WriteMessageInRed("App'en stänges nu!");
                    break;
                }

                //Input price of the asset
                Console.WriteLine("Type Price as 123 and not decimal!");
                Console.Write("Price: ");
                _Price = Convert.ToInt32(Console.ReadLine());
                if ((_Price).ToString().ToLower().Trim() == "exit")
                {
                    WriterExtensions.WriteMessageInRed("App'en stänges nu!");
                    break;
                }

                //if-loop, if the _Category=laptop then add the asset in computerAssets-List else add in mobileAssets-List.
                if ((_Category.ToLower().Trim() == "laptop") && (!String.IsNullOrWhiteSpace(_Category)))
                {
                    computerAssets.Add(new Computers(_Category, _PurchaseDate, _ModelName, Convert.ToInt32(_Price)));
                }
                else
                {
                    mobileAssets.Add(new Mobiles(_Category, _PurchaseDate, _ModelName, Convert.ToInt32(_Price)));
                }
            } while (true);

            Console.WriteLine("Category".PadRight(15) + "PurchaseDate".PadRight(15) + "ModelName".PadRight(15) + "Price".ToString().PadRight(15));

            //Merge computerAssets-List & mobileAssets-List to new List, assetsList
            var assetsList = computerAssets.Concat(mobileAssets).ToList();
            foreach (Assets assetItem in assetsList)
            {
                assetsList.OrderBy(assetsList => assetsList.Category == "laptop").OrderByDescending(assetsList => assetsList.PurchaseDate).ThenBy(assetsList => assetsList.Category == "mobile").OrderByDescending(assetsList=>assetsList.PurchaseDate);

                if ((DateTime.Now > assetItem.PurchaseDate.AddMonths(33)))
                {
                    WriterExtensions.WriteMessageInRed(assetItem.Category.PadRight(15) + Convert.ToDateTime(assetItem.PurchaseDate).ToShortDateString().PadRight(15) + assetItem.ModelName.PadRight(15) + assetItem.Price.ToString().PadRight(15));
                }
                else
                {
                    Console.WriteLine(assetItem.Category.PadRight(15) + Convert.ToDateTime(assetItem.PurchaseDate).ToShortDateString().PadRight(15) + assetItem.ModelName.PadRight(15) + assetItem.Price.ToString().PadRight(15));
                }
            }

            Console.ReadKey();
        }
    }






}

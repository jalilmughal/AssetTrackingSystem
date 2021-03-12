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
            //Check check = new Check();
            Computers computers = new Computers();
            Mobiles mobiles = new Mobiles();

            List<Assets> computerAssets = new List<Assets>();
            List<Assets> mobileAssets = new List<Assets>();

            string _Category = assets.Category;
            string _PurchaseDate = assets.PurchaseDate;
            string _ModelName = assets.ModelName;
            int _Price = assets.Price;

            Console.WriteLine("Type your product details bellow, exit by typing 'exit'.");

            do
            {
                //Input Category of the asset
                Console.WriteLine("Type 'L' for Laptop Computers and 'M' for Mobile Phones!");    
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
                Console.WriteLine("Type Price as 123 and not decimal!");
                Console.Write("Price: ");
                _Price = Convert.ToInt32(Console.ReadLine());
                if ((_Price).ToString().ToLower().Trim() == "exit")
                {
                    WriterExtensions.WriteMessageInRed("App'en stänges nu!");
                    break;
                }

                //if-loop, if the _Category=laptop then add the asset in computerAssets-List else add in mobileAssets-List.
                if ((_Category.ToLower().Trim() == "laptop") && (_Category.ToLower().Trim() == "l") && (!String.IsNullOrWhiteSpace(_Category)) )
                {
                    computerAssets.Add(new Computers(_Category, _PurchaseDate, _ModelName, Convert.ToInt32(_Price)));
                }
                else
                {
                    mobileAssets.Add(new Mobiles(_Category, _PurchaseDate, _ModelName, Convert.ToInt32(_Price)));
                }
            } while (true);

            Console.WriteLine("Category".PadRight(15) + "PurchaseDate".PadRight(15) + "ModelName".PadRight(15) + "Price".ToString().PadRight(15));            
            
            /*for (int asset = 0; asset < computerAssets.Count; asset++)
            {
                Console.WriteLine(computerAssets[asset].Category.PadRight(15) + computerAssets[asset].PurchaseDate.PadRight(15) + computerAssets[asset].ModelName.PadRight(15) + (computerAssets[asset].Price).ToString().PadRight(15));
            }

            foreach (var item in mobileAssets)
            {
                Console.WriteLine(item.Category.PadRight(15) + item.PurchaseDate.PadRight(15) + item.ModelName.PadRight(15) + item.Price.ToString().PadRight(15));
            } */ 
            //OrderBy computerAssets first and then mobileAssets
            //computerAssets.OrderBy(computerAssets=> computerAssets.Category).ThenBy(mobileAssets => mobileAssets.Category);


            //Merge computerAssets-List & mobileAssets-List to new List, assetsList
            var assetsList = computerAssets.Concat(mobileAssets).ToList();
            assetsList.OrderBy(assetsList => assetsList.Category=="laptop").OrderByDescending(assetsList => assetsList.PurchaseDate);

            foreach (Assets assetItem in assetsList)
            {
                Console.WriteLine(assetItem.Category.PadRight(15) + assetItem.PurchaseDate.PadRight(15) + assetItem.ModelName.PadRight(15) + assetItem.Price.ToString().PadRight(15));
            }

            Console.ReadKey();
        }
    }
}

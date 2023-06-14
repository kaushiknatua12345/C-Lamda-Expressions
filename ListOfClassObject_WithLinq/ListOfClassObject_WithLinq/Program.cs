using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfClassObject_WithLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itemList = new List<Item>();
            Item item = new Item();
            Repository repository = new Repository();
            string loopInput = string.Empty;
            do
            {
                Console.WriteLine("Menu:\n1. Insert Data\n2. Display Data\n3. Update Brand Name\n4. Delete Record");
                Console.WriteLine("\nEnter your choice in menu selection: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter Item Code: ");
                        int itemCode = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Item Type: ");
                        string itemType = Console.ReadLine();
                        Console.WriteLine("Enter Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Brand Name: ");
                        string brandName = Console.ReadLine();
                        item = new Item(itemCode, itemType, price, brandName);
                        bool insertResult = repository.AddData(itemList, item);
                        if(insertResult)
                        {
                            Console.WriteLine("\nData Insertion Successful");
                        }
                        else
                        {
                            Console.WriteLine("\nData Insertion Failed");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Menu:\n1. Display all records\n2. Display records sorted in sescending manner by price"+
                            "\n3. Display records where price of items> Rs.500");
                        Console.WriteLine("\nEnter your choice in menu selection: ");
                        int displayChoice = Convert.ToInt32(Console.ReadLine());
                       switch(displayChoice)
                        {
                            case 1:
                                List<Item> displayAllData = repository.DisplayAllData(itemList);
                                if(displayAllData!=null)
                                {
                                    Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3}", "Item Code", "Item Type", "Brand Name", "Price");
                                    foreach(var data in displayAllData)
                                    {
                                        Console.WriteLine(data);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nNo records are present in list");
                                }
                                break;

                            case 2:
                                List<Item> displayAllSortedData = repository.DisplayAllDataInDescendingMannerByPriceSorted(itemList);
                                if (displayAllSortedData != null)
                                {
                                    Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3}", "Item Code", "Item Type", "Brand Name", "Price");
                                    foreach (var data in displayAllSortedData)
                                    {
                                        Console.WriteLine(data);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nNo records are present in lList");
                                }
                                break;

                            case 3:
                                List<Item> displayFilteredData= repository.DisplayItemsWithPriceMoreThanRs500(itemList);
                                if (displayFilteredData != null)
                                {
                                    Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3}", "Item Code", "Item Type", "Brand Name", "Price");
                                    foreach (var data in displayFilteredData)
                                    {
                                        Console.WriteLine(data);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nNo records are present in list");
                                }
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter item id to search");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter updated brand name");
                        string updateBrandName = Console.ReadLine();
                        bool updateResult = repository.UpdateData(itemList, searchId, updateBrandName);
                        if (updateResult)
                        {
                            Console.WriteLine("\nData Updation Successful");
                        }
                        else
                        {
                            Console.WriteLine("\nData Updation Failed");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter item id to search");
                        int searchIdForDelete = Convert.ToInt32(Console.ReadLine());
                        bool deleteResult = repository.DeleteRecord(itemList, searchIdForDelete);
                        if (deleteResult)
                        {
                            Console.WriteLine("\nData Deletion Successful");
                        }
                        else
                        {
                            Console.WriteLine("\nData Deletion Failed");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try Again");
                        break;
                }
                Console.WriteLine("Enter yes to continue with menu selections. Press any other key to stop: ");
                loopInput = Console.ReadLine();
            }
            while (loopInput.Equals("yes"));
            Console.ReadKey();
        }
    }
}

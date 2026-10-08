using System;
using System.Collections;

namespace StoreManager;
class Program
{

    public class Item()
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double RestockCost { get; set; }
        // public bool isExpired { get; set; }

        public static Sell()
        {
            return;
        }

    }

    public static void Main(string[] args)
    {
        // Initialize the array for item inventory
        string[] itemNames = new string[]{"Apple","Banana","Orange"};
        int[] itemQuantity = new int[]{10,16,28};
        double[] itemPrice = new double[]{5.99,7.49,3.79};
        double[] itemRestockCost = new double[]{3.99,5.49,1.79};


        Console.WriteLine("=== Store Program ===");
        string divider = new string('-', 22);
        Console.WriteLine(divider);

        Item Apple = new Item();
        Item Banana = new Item();
        Item Orange = new Item();

        List<Item> inventory = new List<Item>()
        {
            new Item { Name = "Apple", Quantity = 10, Price = 5.99, RestockCost = 3.99 },
            new Item { Name = "Banana", Quantity = 16, Price = 7.49, RestockCost = 5.49 },
            new Item { Name = "Orange", Quantity = 28, Price = 3.79, RestockCost = 1.79 }
        };

        // Apple.Name = "Apple";
        // Apple.Type = "Fruit";
        // Apple.Quantity = 10;
        // Apple.Price = 5.99;
        // Apple.isExpired = false;

        // Banana.Name = "Banana";
        // Banana.Type = "Fruit";
        // Banana.Quantity = 16;
        // Banana.Price = 7.49;
        // Banana.isExpired = false;

        // Orange.Name = "Orange";
        // Orange.Type = "Fruit";
        // Orange.Quantity = 28;
        // Orange.Price = 3.79;
        // Orange.isExpired = false;

    }



}
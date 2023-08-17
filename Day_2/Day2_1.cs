using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    class Item
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; }

        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    class ShoppingCart
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void DisplayCartContents()
        {
            Console.WriteLine("Shopping Cart Contents:");
            foreach (Item item in items)
            {
                Console.WriteLine($"Item: {item.Name}, Price: ${item.Price}, Quantity: {item.Quantity}");
            }
        }

        public double TotalCost
        {
            get
            {
                double totalCost = 0;
                foreach (Item item in items)
                {
                    totalCost += item.Price * item.Quantity;
                }
                return totalCost;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            // Allow user interaction to add items, display cart contents, and calculate total cost
            // You can use Console.ReadLine and Console.WriteLine here

            // Example usage
            Item item1 = new Item("Product A", 10.99, 2);
            cart.AddItem(item1);

            Item item2 = new Item("Product B", 25.50, 3);
            cart.AddItem(item2);

            cart.DisplayCartContents();
            Console.WriteLine($"Total Cost: ${cart.TotalCost:F2}");
        }
    }
}

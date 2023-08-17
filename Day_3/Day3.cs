using System;

namespace OnlineStoreInventory
{
    class Product
    {
        public string ProductID { get; }
        public string Name { get; }
        public double Price { get; }
        public int QuantityInStock { get; }

        public Product(string productID, string name, double price, int quantityInStock)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        }
    }

    class Electronics : Product
    {
        public string Brand { get; }

        public Electronics(string productID, string name, double price, int quantityInStock, string brand)
            : base(productID, name, price, quantityInStock)
        {
            Brand = brand;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Brand: {Brand}");
        }
    }

    class Clothing : Product
    {
        public string Size { get; }

        public Clothing(string productID, string name, double price, int quantityInStock, string size)
            : base(productID, name, price, quantityInStock)
        {
            Size = size;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Size: {Size}");
        }
    }

    class Books : Product
    {
        public string Author { get; }

        public Books(string productID, string name, double price, int quantityInStock, string author)
            : base(productID, name, price, quantityInStock)
        {
            Author = author;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Author: {Author}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Electronics electronicsProduct = new Electronics("E001", "Laptop", 800, 10, "Dell");
            Clothing clothingProduct = new Clothing("C001", "T-Shirt", 20, 50, "Medium");
            Books booksProduct = new Books("B001", "Harry Potter and the Sorcerer's Stone", 15, 20, "J.K. Rowling");

            electronicsProduct.DisplayDetails();
            Console.WriteLine();
            clothingProduct.DisplayDetails();
            Console.WriteLine();
            booksProduct.DisplayDetails();
        }
    }
}

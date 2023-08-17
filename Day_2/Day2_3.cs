using System;
using System.Collections.Generic;

namespace OnlineStore
{
    class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int QuantityInStock { get; private set; }
        public string Category { get; }

        public Product(string name, double price, int quantityInStock, string category)
        {
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
            Category = category;
        }

        public void DecreaseStock(int quantity)
        {
            QuantityInStock -= quantity;
        }

        public void IncreaseStock(int quantity)
        {
            QuantityInStock += quantity;
        }
    }

    class Store
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Store Products List:");
            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: ${product.Price}, Quantity in Stock: {product.QuantityInStock}, Category: {product.Category}");
            }
        }

        public double CalculateTotalValue()
        {
            double totalValue = 0;
            foreach (Product product in products)
            {
                totalValue += product.Price * product.QuantityInStock;
            }
            return totalValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Product product1 = new Product("Product A", 10.99, 5, "Electronics");
            store.AddProduct(product1);

            Product product2 = new Product("Product B", 25.50, 3, "Clothing");
            store.AddProduct(product2);

            store.DisplayProducts();
            Console.WriteLine($"Total Value: ${store.CalculateTotalValue():F2}");
        }
    }
}

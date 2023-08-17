using System;

namespace CreditChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double limit = 10000;
            double price;

            Console.Write("Enter the purchase price: ");
            price = Convert.ToDouble(Console.ReadLine());

            if (price > limit)
                Console.WriteLine("Error!");
            else
                Console.WriteLine("Approved");
        }
    }
}

using System;

namespace TempTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTemps = 0;
            int numTemps = 0;
            int temp;
            int sumTemps = 0;
            int minTemp = 20;
            int maxTemp = 130;

            while (true)
            {
                Console.Write("Enter a temperature (20 - 130) or a sentinel value to stop: ");
                temp = Convert.ToInt32(Console.ReadLine());

                if (temp == -1)
                    break;

                if (temp >= minTemp && temp <= maxTemp)
                {
                    sumTemps += temp;
                    numTemps++;
                }
                else
                {
                    Console.WriteLine("Invalid temperature! Temperature should be between 20 and 130.");
                }
            }

            if (numTemps > 0)
            {
                double avgTemp = (double)sumTemps / numTemps;
                Console.WriteLine($"Number of temperatures entered: {numTemps}");
                Console.WriteLine($"Average temperature: {avgTemp:F2}");
            }
            else
            {
                Console.WriteLine("No valid temperatures were entered.");
            }
        }
    }
}

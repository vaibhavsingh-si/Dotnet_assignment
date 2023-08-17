using System;

namespace ArrayOperations
{
    class Program
    {
        static void assing_DisplayReverse(int[] arr)
        {
            Console.WriteLine("Array in reverse order:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static int assing_FindSum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        static void assing_CopyArray(int[] source, int[] destination)
        {
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
        }

        static int[] assing_DeleteElement(int[] arr, int position)
        {
            if (position < 0 || position >= arr.Length)
            {
                Console.WriteLine("Invalid position!");
                return arr;
            }

            int[] newArr = new int[arr.Length - 1];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != position)
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }
            return newArr;
        }

        static void Main(string[] args)
        {
            const int n = 5; // Change this value to the desired array size
            
            int[] numbers = new int[n];
            Console.WriteLine($"Enter {n} numbers:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            assing_DisplayReverse(numbers);
            int sum = assing_FindSum(numbers);
            Console.WriteLine("Sum of array elements: " + sum);

            int[] copyArray = new int[n];
            assing_CopyArray(numbers, copyArray);
            Console.WriteLine("Copied array:");
            foreach (int num in copyArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Enter the position to delete element:");
            int position = Convert.ToInt32(Console.ReadLine());
            numbers = assing_DeleteElement(numbers, position);
            Console.WriteLine("Array after deletion:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

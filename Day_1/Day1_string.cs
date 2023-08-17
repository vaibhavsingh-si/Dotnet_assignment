using System;

namespace StringFun
{
    class Prg
    {
        static int CharCount(string txt, char tgt)
        {
            int cnt = 0;
            foreach (char c in txt)
            {
                if (c == tgt)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        static void Main(string[] args)
        {
            // Count Occurrences of a Character
            Console.Write("Enter some text: ");
            string inp = Console.ReadLine();

            Console.Write("Enter a character to count: ");
            char tgtChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int occur = CharCount(inp, tgtChar);
            Console.WriteLine($"The character '{tgtChar}' occurs {occur} times in the text.");

            // Rewrite String in Alphabetical Order
            Console.Write("\nEnter a string: ");
            string strInput = Console.ReadLine();

            char[] chrArr = strInput.ToCharArray();
            Array.Sort(chrArr);
            string alphaOrder = new string(chrArr);

            Console.WriteLine($"Alphabetical order: {alphaOrder}");

            // Extract Substring from a Given String
            Console.Write("\nEnter a string: ");
            string subInput = Console.ReadLine();

            Console.Write("Enter the starting index: ");
            int st = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the substring: ");
            int len = int.Parse(Console.ReadLine());

            if (st >= 0 && st + len <= subInput.Length)
            {
                string extrSub = subInput.Substring(st, len);
                Console.WriteLine($"Extracted substring: {extrSub}");
            }
            else
            {
                Console.WriteLine("Invalid start index or length.");
            }

            // Search Position of a Substring Within a String
            Console.Write("\nEnter a string: ");
            string srchStr = Console.ReadLine();

            Console.Write("Enter the substring to search: ");
            string subSrch = Console.ReadLine();

            int pos = srchStr.IndexOf(subSrch);
            if (pos != -1)
            {
                Console.WriteLine($"Substring found at position: {pos}");
            }
            else
            {
                Console.WriteLine("Substring not found in the string.");
            }

            // Compare Substrings with and without Case Sensitivity
            Console.Write("\nEnter the first substring: ");
            string sub1 = Console.ReadLine();

            Console.Write("Enter the second substring: ");
            string sub2 = Console.ReadLine();

            bool ignoreCase = string.Equals(sub1, sub2, StringComparison.OrdinalIgnoreCase);
            bool considerCase = string.Equals(sub1, sub2, StringComparison.Ordinal);

            Console.WriteLine($"Ignoring case: {ignoreCase}");
            Console.WriteLine($"Considering case: {considerCase}");
        }
    }
}

namespace SortSequenceInIncreasingOrder
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter numbers: ");
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine.Trim() == string.Empty)
                {
                    break;
                }

                int number = int.Parse(inputLine);
                numbers.Add(number);
            }

            numbers.Sort();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

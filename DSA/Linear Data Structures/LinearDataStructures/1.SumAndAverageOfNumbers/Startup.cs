namespace SumAndAverageOfNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

            int sum = numbers.Sum();
            double average = numbers.Average();

            Console.WriteLine("Sum: {0}, Average: {1:F2}", sum, average);
        }
    }
}

namespace Dividers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static List<int> numbers = new List<int>();

        public static void Main()
        {
            int[] digitsSet = ReadAndParseInput();

            Array.Sort(digitsSet);
            PermuteRep(digitsSet, 0, digitsSet.Length);

            int numberWithMinDividersCount = FindNumberWithMinDividersCount();
            Console.WriteLine(numberWithMinDividersCount);
        }

        private static int FindNumberWithMinDividersCount()
        {
            int minDividersCount = int.MaxValue;
            int numberWithMinDividersCount = numbers[0];
            foreach (var number in numbers)
            {
                int numberToInt = number;
                int dividersCount = FindDividersCount(numberToInt);

                if (dividersCount < minDividersCount)
                {
                    minDividersCount = dividersCount;
                    numberWithMinDividersCount = numberToInt;
                }
            }

            return numberWithMinDividersCount;
        }

        private static int FindDividersCount(int number)
        {
            int dividеrsCount = 0;
            if (number == 1)
            {
                return 1;
            }

            dividеrsCount = 2;
            int maxDividеr = (int)Math.Truncate(Math.Sqrt(number));
            for (int dividеr = 2; dividеr <= maxDividеr; dividеr++)
            {
                if (number % dividеr == 0)
                {
                    dividеrsCount += 2;
                }
            }

            if (maxDividеr * maxDividеr == number)
            {
                dividеrsCount--;
            }

            return dividеrsCount;
        }

        private static void PermuteRep(int[] arr, int start, int n)
        {
            numbers.Add(int.Parse(string.Join("", arr)));

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                }

                // Undo all modifications done by the
                // previous recursive calls and swaps
                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[n - 1] = firstElement;
            }
        }

        private static void Swap(ref int first, ref int second)
        {
            int oldFirst = first;
            first = second;
            second = oldFirst;
        }

        private static int[] ReadAndParseInput()
        {
            int n = int.Parse(Console.ReadLine());
            int[] digitsSet = new int[n];

            for (int i = 0; i < n; i++)
            {
                digitsSet[i] = int.Parse(Console.ReadLine());
            }

            return digitsSet;
        }
    }
}

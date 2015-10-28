namespace RemoveOddOccurrence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> array = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            Console.WriteLine("Before removing");
            Console.WriteLine(string.Join(", ", array));

            Dictionary<int, int> elementsCount = new Dictionary<int, int>();
            int index = 0;
            while (index < array.Count)
            {
                int element = array[index];
                if (elementsCount.ContainsKey(element))
                {
                    elementsCount[element]++;   
                }
                else
                {
                    elementsCount.Add(element, 1);
                }

                index++;          
            }

            foreach (var pair in elementsCount)
            {
                if (pair.Value % 2 != 0)
                {
                    array.RemoveAll(n => n == pair.Key);
                }
            }

            Console.WriteLine("After removing all numbers that occur odd number of times");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}

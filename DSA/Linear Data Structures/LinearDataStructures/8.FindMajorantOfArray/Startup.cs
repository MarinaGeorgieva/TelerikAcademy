namespace FindMajorantOfArray
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {
            List<int> array = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int minOccurrences = array.Count / 2 + 1;

            SortedDictionary<int, int> elementsCount = new SortedDictionary<int, int>();
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
                if (pair.Value >= minOccurrences)
                {
                    Console.WriteLine("The majorant of the array is {0}", pair.Key);
                    return;
                }
            }

            Console.WriteLine("The given array does not have a majorant!");
        }
    }
}

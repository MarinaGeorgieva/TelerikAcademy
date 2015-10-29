namespace FindMajorantOfArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
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

            int maxCount = 1;
            int majorant = elementsCount.Keys.First();
            foreach (var pair in elementsCount)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    majorant = pair.Key;
                }
            }

            if (maxCount >= minOccurrences)
            {
                Console.WriteLine("The majorant is {0}", majorant);
            }
            else
            {
                Console.WriteLine("The given array does not have a majorant!");
            }
        }
    }
}

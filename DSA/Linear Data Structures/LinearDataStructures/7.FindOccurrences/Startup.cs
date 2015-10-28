namespace FindOccurrences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> array = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
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
                Console.WriteLine("{0} ---> {1} time(s)", pair.Key, pair.Value);
            }
        }
    }
}

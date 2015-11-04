namespace _1.CountOccurrences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<double> array = new List<double> { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> elementsCount = new Dictionary<double, int>();
            int index = 0;
            while (index < array.Count)
            {
                double element = array[index];
                if (!elementsCount.ContainsKey(element))
                {
                    elementsCount.Add(element, 1);
                }
                else
                {
                    elementsCount[element]++;
                }

                index++;
            }

            foreach (var pair in elementsCount)
            {
                Console.WriteLine("{0} --> {1} times", pair.Key, pair.Value);
            }
        }
    }
}

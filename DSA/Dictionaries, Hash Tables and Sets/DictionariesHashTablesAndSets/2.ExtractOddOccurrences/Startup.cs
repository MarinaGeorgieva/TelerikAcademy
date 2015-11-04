namespace _2.ExtractOddOccurrences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<string> array = new List<string> { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> elementsCount = new Dictionary<string, int>();
            int index = 0;
            while (index < array.Count)
            {
                string element = array[index];
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

            List<string> result = new List<string>();
            foreach (var pair in elementsCount)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

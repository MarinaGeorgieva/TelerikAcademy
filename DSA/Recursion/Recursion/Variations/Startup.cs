namespace Variations
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            // n = 3, k = 2
            string[] set = new string[] { "hi", "a", "b" };
            string[] subset = new string[2];

            GenerateVariations(set, subset, 0);
        }

        private static void GenerateVariations(string[] set, string[] subset, int index)
        {
            if (index == subset.Length)
            {
                Console.WriteLine("({0})", string.Join(" ", subset));
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                subset[index] = set[i];
                GenerateVariations(set, subset, index + 1);
            }
        }
    }
}

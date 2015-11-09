namespace StringCombinationsWithoutDuplicates
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            // n = 3, k = 2
            string[] set = new string[] { "test", "rock", "fun" };
            string[] subset = new string[2];

            GenerateCombinations(set, subset, 0);
        }

        private static void GenerateCombinations(string[] set, string[] subset, int index, int start = 0)
        {
            if (index == subset.Length)
            {
                Console.WriteLine("({0})", string.Join(" ", subset));
                return;
            }

            for (int i = start; i < set.Length; i++)
            {
                subset[index] = set[i];
                GenerateCombinations(set, subset, index + 1, i + 1);
            }
        }
    }
}

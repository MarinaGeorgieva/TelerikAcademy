namespace CombinationsWithoutDuplicates
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] combination = new int[k];
            GenerateCombinations(combination, 0, 1, n);
        }

        private static void GenerateCombinations(int[] combination, int index, int start, int end)
        {
            if (index == combination.Length)
            {
                Console.WriteLine("({0})", string.Join(" ", combination));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                combination[index] = i;
                GenerateCombinations(combination, index + 1, i + 1, end);
            }
        }
    }
}

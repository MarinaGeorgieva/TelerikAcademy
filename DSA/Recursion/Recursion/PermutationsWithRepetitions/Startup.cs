namespace PermutationsWithRepetitions
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int[] firstSet = new int[] { 1, 3, 5, 5 };
            GeneratePermutations(firstSet);

            int[] secondSet = new int[] { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            GeneratePermutations(secondSet);
        }

        private static void GeneratePermutations(int[] set, int start = 0)
        {
            PrintPermutation(set);

            if (start < set.Length)
            {
                for (int i = set.Length - 2; i >= start; i--)
                {
                    for (int j = i + 1; j < set.Length; j++)
                    {
                        if (set[i] != set[j])
                        {
                            Swap(set, i, j);

                            GeneratePermutations(set, i + 1);
                        }
                    }

                    var value = set[i];
                    for (int k = i; k < set.Length - 1;)
                    {
                        set[k] = set[++k];
                    }

                    set[set.Length - 1] = value;
                }
            }
        }

        private static void Swap(int[] array, int left, int right)
        {
            int value = array[left];
            array[left] = array[right];
            array[right] = value;
        }

        private static void PrintPermutation(int[] set)
        {
            Console.WriteLine("({0})", string.Join(", ", set));
        }
    }
}

namespace Permutations
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] permutation = new int[n];
            FillArray(permutation, n);
            GeneratePermutations(permutation, n);
        }

        private static void FillArray(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }
        }

        private static void GeneratePermutations(int[] permutation, int n)
        {
            if (n == 1)
            {
                Console.WriteLine("({0})", string.Join(" ", permutation));
                return;
            }

            for (int i = 0; i < n - 1; i++)
            {
                GeneratePermutations(permutation, n - 1);

                if (n % 2 == 0)
                {
                    Swap(permutation, i, n - 1);
                }
                else
                {
                    Swap(permutation, 0, n - 1);
                }
            }

            GeneratePermutations(permutation, n - 1);
        }

        private static void Swap(int[] array, int left, int right)
        {
            int value = array[left];
            array[left] = array[right];
            array[right] = value;
        }
    }
}

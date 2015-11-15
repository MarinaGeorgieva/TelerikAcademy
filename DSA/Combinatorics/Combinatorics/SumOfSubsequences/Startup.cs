namespace SumOfSubsequences
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string[] nAndK = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int n = int.Parse(nAndK[0]);
                int k = int.Parse(nAndK[1]);

                int[] sequence = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                Console.WriteLine(CalculateSumOfSubsequences(n, k, sequence));
            }            
        }

        public static long CalculateSumOfSubsequences(int n, int k, int[] sequence)
        {
            long sumOfSubsequences = BinomialCoeff(n - 1, k) * CalculateSum(sequence);
            return sumOfSubsequences;
        }

        private static long BinomialCoeff(int n, int k)
        {
            long result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= n - (k - i);
                result /= i;
            }

            return result;
        }

        public static long CalculateSum(int[] sequence)
        {
            long sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }

            return sum;
        }        
    }
}

namespace ColorfulBallsSequence
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Startup
    {
        public static void Main()
        {
            var colorsSequence = Console.ReadLine().ToCharArray();

            var colorsOccurrences = FindDifferentColorsOccurrences(colorsSequence);
            var permutationsCount = FindPermutationsCount(colorsSequence, colorsOccurrences); 
            Console.WriteLine(permutationsCount);
        }

        private static BigInteger FindPermutationsCount(char[] sequence, Dictionary<char, int> dictionary)
        {
            BigInteger permutationsCount = Factorial(sequence.Length);
            foreach (var pair in dictionary)
            {
                permutationsCount /= Factorial(pair.Value);
            }

            return permutationsCount;
        }

        private static Dictionary<char, int> FindDifferentColorsOccurrences(char[] sequence)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            int index = 0;
            while (index < sequence.Length)
            {
                if (!dictionary.ContainsKey(sequence[index]))
                {
                    dictionary.Add(sequence[index], 1);
                }
                else
                {
                    dictionary[sequence[index]]++;
                }

                index++;
            }

            return dictionary;
        }

        private static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}

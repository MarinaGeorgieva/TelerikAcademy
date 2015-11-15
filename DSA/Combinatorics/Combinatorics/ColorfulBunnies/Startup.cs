namespace ColorfulBunnies
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Startup
    {
        public static void Main()
        {
            int[] answers = ReadAndParseInput();

            Dictionary<int, BigInteger> dictionary = FindDifferentAnswersOccurrences(answers);

            BigInteger minBunniesCount = FindMinBunniesCount(dictionary); 
            Console.WriteLine(minBunniesCount);
        }

        private static BigInteger FindMinBunniesCount(Dictionary<int, BigInteger> dictionary)
        {
            BigInteger minBunniesCount = 0;
            foreach (var pair in dictionary)
            {
                BigInteger groupOfBunniesCount = pair.Value / (pair.Key + 1);
                BigInteger remainder = pair.Value % (pair.Key + 1);

                if (groupOfBunniesCount < 1)
                {
                    groupOfBunniesCount = 1;
                    remainder = 0;
                }

                if (remainder != 0)
                {
                    minBunniesCount += (groupOfBunniesCount + 1) * (pair.Key + 1);
                }
                else
                {
                    minBunniesCount += groupOfBunniesCount * (pair.Key + 1);
                }                
            }

            return minBunniesCount;
        }

        private static Dictionary<int, BigInteger> FindDifferentAnswersOccurrences(int[] answers)
        {
            Dictionary<int, BigInteger> dictionary = new Dictionary<int, BigInteger>();
            int index = 0;
            while (index < answers.Length)
            {
                if (!dictionary.ContainsKey(answers[index]))
                {
                    dictionary.Add(answers[index], 1);
                }
                else
                {
                    dictionary[answers[index]]++;
                }

                index++;
            }

            return dictionary;
        }

        private static int[] ReadAndParseInput()
        {
            int askedBunniesCount = int.Parse(Console.ReadLine());
            int[] answers = new int[askedBunniesCount];

            for (int i = 0; i < askedBunniesCount; i++)
            {
                answers[i] = int.Parse(Console.ReadLine());
            }

            return answers;
        } 
    }
}

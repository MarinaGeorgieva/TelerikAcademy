namespace FindLongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> sequence = new List<int> { 2, 2, 5, 1, 6, 6, 6, 7, 1, 1, 1, 1, 1, 3, 3, 10, 8, 8, 8, 8, 8, 8 };
            List<int> longestSubsequence = FindLongestSubsequence(sequence);
            Console.WriteLine("Initial sequence:");
            Console.WriteLine(string.Join(", ", sequence));
            Console.WriteLine("The longest subsequence of equal numbers:");
            Console.WriteLine(string.Join(", ", longestSubsequence));
        }

        private static List<int> FindLongestSubsequence(List<int> sequence)
        {
            List<int> result = new List<int>();
            int currentLength = 1;
            int bestIndex = 0;
            int bestLength = 1;
            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentLength++;
               
                }
                else
                {
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestIndex = i;                        
                    }

                    currentLength = 1;
                }  
                
                if (i == sequence.Count - 2)
                {
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestIndex = i;
                    }
                }              
            }

            for (int i = 0; i < bestLength; i++)
            {
                result.Add(sequence[bestIndex]);
            }

            return result;
        }
    }
}

namespace DecreasingAbsoluteDifferences
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class DecreasingAbsoluteDifferences
    {
        public static void Main()
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < numberOfInputLines; i++)
            {
                long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                long[] sequenceOfAbsoluteDifferences = FindSequenceOfAbsoluteDifferences(numbers);
                long[] sequenceOfSequenceOfAbsoluteDifferences = FindSequenceOfAbsoluteDifferences(sequenceOfAbsoluteDifferences);

                if (CheckIfAbsoluteDifferencesAreOnlyOneOrZero(sequenceOfSequenceOfAbsoluteDifferences) && 
                    CheckIfDecreasingSequence(sequenceOfAbsoluteDifferences))
                {
                    result.AppendLine("True");
                }
                else
                {
                   result.AppendLine("False");
                }  
            }

            Console.WriteLine(result.ToString());
        }

        private static bool CheckIfDecreasingSequence(long[] sequence)
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] < sequence[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckIfAbsoluteDifferencesAreOnlyOneOrZero(long[] sequence)
        {            
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] != 0 && sequence[i] != 1)
                {
                    return false;
                }
            }

            return true;
        }

        private static long[] FindSequenceOfAbsoluteDifferences(long[] numbers)
        {
            long[] sequenceOfAbsoluteDifferences = new long[numbers.Length - 1];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                long currentNumber = numbers[i];
                long nextNumber = numbers[i + 1];
                sequenceOfAbsoluteDifferences[i] = Math.Abs(currentNumber - nextNumber);
            }

            return sequenceOfAbsoluteDifferences;
        }
    }
}

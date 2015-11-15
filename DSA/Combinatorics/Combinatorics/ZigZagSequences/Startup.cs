namespace ZigZagSequences
{
    using System;

    public class Startup
    {
        static int counter = 0;

        static bool[] used;

        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[] sequence = new int[k];
            used = new bool[n];

            GenerateVariationsNoRepetitions(sequence, 0);
            Console.WriteLine(counter);
        }

        private static bool IsZigZagSequence(int[] sequence)
        {
            if (sequence.Length == 1)
            {
                return true;
            }

            else if (sequence.Length == 2)
            {
                return sequence[0] > sequence[1];
            }

            for (int i = 1; i < sequence.Length - 1; i++)
            {
                if (i % 2 == 1 && !(sequence[i - 1] > sequence[i] && sequence[i] < sequence[i + 1]))
                {
                    return false;
                }
                
                if (i % 2 == 0 && !(sequence[i - 1] < sequence[i] && sequence[i] > sequence[i + 1]))
                {
                    return false;
                }
            }

            return true;
        }

        private static void GenerateVariationsNoRepetitions(int[] sequence, int index)
        {
            if (index == sequence.Length)
            {
                if (IsZigZagSequence(sequence))
                {
                    counter++;
                }

                return;
            }

            for (int i = 0; i < used.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    sequence[index] = i;
                    GenerateVariationsNoRepetitions(sequence, index + 1);
                    used[i] = false;
                }
            }
        }
    }
}


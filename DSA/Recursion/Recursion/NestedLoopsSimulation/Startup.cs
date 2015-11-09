namespace NestedLoopsSimulation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            SimulateLoops(array, n, 0);
        }

        private static void SimulateLoops(int[] array, int n, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                SimulateLoops(array, n, index + 1);
            }
        }
    }
}

namespace FindShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            while (n <= m)
            {
                queue.Enqueue(m);

                if (m / 2 >= n)
                {
                    if (m % 2 == 0)
                    {
                        m /= 2;
                    }
                    else
                    {
                        m--;
                    }
                }
                else
                {
                    if (m - 2 >= n)
                    {
                        m -= 2;
                    }
                    else
                    {
                        m--;
                    }
                }
            }

            Console.WriteLine(string.Join(" --> ", queue.Reverse()));
        }
    }
}

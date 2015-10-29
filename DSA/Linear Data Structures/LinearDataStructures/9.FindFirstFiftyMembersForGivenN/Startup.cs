namespace FindFirstFiftyMembersForGivenN
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private const int MaxElementsCount = 50;

        public static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            Console.WriteLine("Printing the first 50 elements for n={0}:", n);
            int index = 0;
            while (index < MaxElementsCount)
            {
                int currentElement = queue.Dequeue();
                if (index != MaxElementsCount - 1)
                {
                    Console.Write("{0}, ", currentElement);
                } 
                else
                {
                    Console.WriteLine(currentElement);
                }
                               
                queue.Enqueue(currentElement + 1);
                queue.Enqueue(2 * currentElement + 1);
                queue.Enqueue(currentElement + 2);
                index++;
            }

            Console.WriteLine();
        }
    }
}

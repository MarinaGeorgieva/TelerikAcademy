namespace ReverseSequenceOfNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter {0} numbers: ", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                stack.Push(number);
            }

            Console.WriteLine("Reversed:");
            foreach (var number in stack)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}

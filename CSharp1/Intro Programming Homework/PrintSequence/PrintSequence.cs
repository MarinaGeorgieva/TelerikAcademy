// Problem 9. Print a Sequence
// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine(i);
                i++;
                Console.WriteLine(-i);
            }
        }
    }
}

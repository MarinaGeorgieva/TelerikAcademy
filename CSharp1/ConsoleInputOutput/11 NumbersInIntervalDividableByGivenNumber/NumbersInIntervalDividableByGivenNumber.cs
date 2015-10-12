// Problem 11.* Numbers in Interval Dividable by Given Number

// Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
// such that the reminder of the division by 5 is 0.

using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the start of the interval: ");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end of the interval: ");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int p = 0;

        if (end >= start)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                    Console.Write("{0}| ", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are {0} numbers between {1} and {2} such that the reminder of the division by 5 is 0.", p, start, end);
        }
        else
        {
            Console.WriteLine("The entered interval is invalid!");
        }
    }
}


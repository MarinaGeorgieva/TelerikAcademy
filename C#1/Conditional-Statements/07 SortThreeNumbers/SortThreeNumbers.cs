// Problem 7. Sort 3 Numbers with Nested Ifs

// Write a program that enters 3 real numbers and prints them sorted in descending order.

using System;

class SortThreeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (a >= c)
            {
                if (b >= c)
                {
                    Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", a, c, b);
                }
            }            
            else 
            {
                Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", c, a, b);
            }
        }
        else if (a <= b)
        {
            if (a <= c)
            {
                if (b <= c)
                {
                    Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", b, a, c);
            }
        }        
    }
}


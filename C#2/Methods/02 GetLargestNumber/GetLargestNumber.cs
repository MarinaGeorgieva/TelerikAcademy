// Problem 2. Get largest number

// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetLargestNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter first integer: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third integer: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Biggest number of {0}, {1}, {2} is {3}", a, b, c, GetMax(GetMax(a, b), c));

    }

    static int GetMax(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}


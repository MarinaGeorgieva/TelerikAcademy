// Problem 16.** Bit Exchange (Advanced)

// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.

using System;

class BitsExchangeAdvanced
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter a position p: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a position q: ");
        int q = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = p, j = q, l = k; (i <= 32 && j <= 32) && (l > 0); i++, j++, l--)
        {
            if (((number >> i) & 1) != ((number >> j) & 1))
            {
                number = (uint)(number ^ (1 << i));
                number = (uint)(number ^ (1 << j));
            }    
        }
        Console.WriteLine("The number after exchanging bits is: " + number);
    }
}


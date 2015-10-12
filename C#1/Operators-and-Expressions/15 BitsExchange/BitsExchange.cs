// Problem 15.* Bits Exchange

// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());

        for (int i = 3, j = 24; i < 6; i++, j++) 
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


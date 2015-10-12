// Problem 8. Binary short

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of {0} is {1}", number, GetBinary(number));
    }

    static string GetBinary(short number)
    {
        string binaryNumber = "";

        for (int i = 0; i < 16; i++)
        {
            binaryNumber = (number >> i & 1) + binaryNumber;
        }

        return binaryNumber;
    }
}


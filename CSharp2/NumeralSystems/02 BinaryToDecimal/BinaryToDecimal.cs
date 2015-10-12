// Problem 2. Binary to decimal

// Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a binary integer number: ");
        string binaryNumber = Console.ReadLine();

        Console.WriteLine("Binary number {0} converted to decimal is {1}", binaryNumber, ConverBinToDec(binaryNumber));
    }

    static long ConverBinToDec(string number)
    {
        int power = number.Length - 1;
        long decimalNumber = 0;

        foreach (char digit in number)
        {
            decimalNumber += (long)((digit - '0') * Math.Pow(2, power));
            power--;
        }

        return decimalNumber;
    }
}


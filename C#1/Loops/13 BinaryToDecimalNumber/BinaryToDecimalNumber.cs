// Problem 13. Binary to Decimal Number

// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.

using System;

class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a binary integer number: ");
        string binaryNumber = Console.ReadLine();

        int power = binaryNumber.Length - 1;
        long decimalNumber = 0;

        foreach (char digit in binaryNumber)
        {
            decimalNumber += (long)((digit - '0') * Math.Pow(2, power));
            power--;
        }

        Console.WriteLine("Binary number {0} converted to decimal is {1}", binaryNumber, decimalNumber);
    }
}


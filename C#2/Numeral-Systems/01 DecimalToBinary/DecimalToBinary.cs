// Problem 1. Decimal to binary

// Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a decimal integer number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Decimal number {0} converted to binary is {1}", decimalNumber, ConvertDecToBin(decimalNumber));
    }

    static string ConvertDecToBin(long number)
    {
        string bin = "";

        do
        {
            if (number % 2 == 0)
            {
                bin += 0;
            }
            else
            {
                bin += 1;
            }
            number /= 2;
        } while (number != 0);

        string binaryNumber = "";

        for (int i = bin.Length - 1; i >= 0; i--)
        {
            binaryNumber += bin[i];
        }

        return binaryNumber;
    }
}


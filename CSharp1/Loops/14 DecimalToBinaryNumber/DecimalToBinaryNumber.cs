// Problem 14. Decimal to Binary Number

// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.

using System;

class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a decimal integer number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        string bin = "";
        long dec = decimalNumber; 

        do
        {
            if (dec % 2 == 0)
            {
                bin += 0;
            }
            else
            {
                bin += 1;
            }
            dec /= 2;
        } while (dec != 0);

        string binaryNumber = "";

        for (int i = bin.Length - 1; i >= 0; i--)
        {
            binaryNumber += bin[i];
        }

        Console.WriteLine("Decimal number {0} converted to binary is {1}", decimalNumber, binaryNumber);
    }
}


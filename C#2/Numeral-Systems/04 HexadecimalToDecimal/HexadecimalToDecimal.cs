// Problem 4. Hexadecimal to decimal

// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a hexadecimal integer number: ");
        string hexadecimalNumber = Console.ReadLine();

        Console.WriteLine("Hexadecimal number {0} converted to decimal is {1}", hexadecimalNumber, ConvertHexToDec(hexadecimalNumber));
    }

    static long ConvertHexToDec(string number)
    {
        int power = number.Length - 1;
        long decimalNumber = 0;

        for (int i = 0; i < number.Length; i++)
        {
            int digit;

            switch (number[i])
            {
                case 'A': digit = 10;
                    break;
                case 'B': digit = 11;
                    break;
                case 'C': digit = 12;
                    break;
                case 'D': digit = 13;
                    break;
                case 'E': digit = 14;
                    break;
                case 'F': digit = 15;
                    break;
                default: digit = number[i] - '0';
                    break;
            }
            decimalNumber += (long)(digit * Math.Pow(16, power));
            power--;
        }

        return decimalNumber;
    }
}


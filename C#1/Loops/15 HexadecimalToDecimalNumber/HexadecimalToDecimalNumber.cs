// Problem 15. Hexadecimal to Decimal Number

// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.

using System;

class HexadecimalToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a hexadecimal integer number: ");
        string hexadecimalNumber = Console.ReadLine();

        int power = hexadecimalNumber.Length - 1;
        long decimalNumber = 0;

        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            int digit;

            switch (hexadecimalNumber[i])
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
                default: digit = hexadecimalNumber[i] - '0';
                    break;
            }
            decimalNumber += (long)(digit * Math.Pow(16, power));
            power--;
        }

        Console.WriteLine("Hexadecimal number {0} converted to decimal is {1}", hexadecimalNumber, decimalNumber);
    }
}


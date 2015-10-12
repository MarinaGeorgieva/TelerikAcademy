// Problem 3. Decimal to hexadecimal

// Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a decimal integer number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Decimal number {0} converted to hexadecimal is {1}", decimalNumber, ConvertDecToHex(decimalNumber));
    }

    static string ConvertDecToHex(long number)
    {
        string hex = "";

        do
        {
            long remainder = number % 16;

            switch (remainder)
            {
                case 10: hex += "A";
                    number /= 16;
                    break;
                case 11: hex += "B";
                    number /= 16;
                    break;
                case 12: hex += "C";
                    number /= 16;
                    break;
                case 13: hex += "D";
                    number /= 16;
                    break;
                case 14: hex += "E";
                    number /= 16;
                    break;
                case 15: hex += "F";
                    number /= 16;
                    break;
                default: hex += remainder;
                    number /= 16;
                    break;
            }
        } while (number >= 16);

        long lastQuotient = number % 16;

        switch (lastQuotient)
        {
            case 10: hex += "A";
                break;
            case 11: hex += "B";
                break;
            case 12: hex += "C";
                break;
            case 13: hex += "D";
                break;
            case 14: hex += "E";
                break;
            case 15: hex += "F";
                break;
            default: hex += lastQuotient;
                break;
        }

        string hexadecimalNumber = "";

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            hexadecimalNumber += hex[i];
        }

        return hexadecimalNumber;
    }
}


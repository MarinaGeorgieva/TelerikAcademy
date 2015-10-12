// Problem 16. Decimal to Hexadecimal Number

// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.

using System;

class DecimalToHexadecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a decimal integer number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        string hex = "";
        long dec = decimalNumber;

        do
        {
            long remainder = dec % 16;

            switch (remainder)
            {
                case 10: hex += "A";
                    dec /= 16;
                    break;
                case 11: hex += "B";
                    dec /= 16;
                    break;
                case 12: hex += "C";
                    dec /= 16;
                    break;
                case 13: hex += "D";
                    dec /= 16;
                    break;
                case 14: hex += "E";
                    dec /= 16;
                    break;
                case 15: hex += "F";
                    dec /= 16;
                    break;
                default: hex += remainder;
                    dec /= 16;
                    break;
            }
        } while (dec >= 16);

        long lastQuotient = dec % 16;

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

        Console.WriteLine("Decimal number {0} converted to hexadecimal is {1}", decimalNumber, hexadecimalNumber);
    }
}


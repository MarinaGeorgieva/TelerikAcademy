// Problem 7. One system to any other

// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

class OneSystemToAnyOther
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();

        Console.WriteLine("Enter base system to convert: ");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter base system to convert to: ");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} converted to {1} system is {2}", number, d, ConvertFromDec(ConvertToDec(number, s), d));
    }

    static long ConvertToDec(string number, int s)
    {
        long result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(number[i]))
            {
                result += (long)((number[i] - '0') * Math.Pow(s, number.Length - 1 - i));
            }
            else
            {
                result += (long)((number[i] - 'A' + 10) * Math.Pow(s, number.Length - 1 - i));
            }
        }

        return result;
    }

    static string ConvertFromDec(long number, int d)
    {
        string result = "";

        do
        {
            if (number % d < 10)
            {
                result += number % d;
            }
            else
            {
                result += (char)(number % d + 'A' - 10);
            }
            number /= d;
        } while (number != 0);

        string resultNumber = "";

        for (int i = result.Length - 1; i >= 0; i--)
        {
            resultNumber += result[i];
        }

        return resultNumber;
    }
}


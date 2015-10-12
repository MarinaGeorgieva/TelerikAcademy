// Problem 7. Reverse number

// Write a method that reverses the digits of given decimal number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();

        Console.WriteLine("Reversed number is {0}", Reverse(number));
    }

    static double Reverse(string number)
    {
        char[] numberChar = number.ToCharArray();
        char[] result = new char[numberChar.Length];

        for (int index = 0; index < numberChar.Length; index++)
        {
            if (Char.IsDigit(numberChar[index]) || numberChar[index] == '.' || numberChar[index] == ',')
            {
                result[numberChar.Length - 1 - index] = numberChar[index];
            }            
        }

        return double.Parse(new string(result));
    }
}


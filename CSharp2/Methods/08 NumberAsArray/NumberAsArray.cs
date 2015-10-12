// Problem 8. Number as array

// Write a method that adds two positive integer numbers represented as arrays of digits 
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberAsArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        string firstNumber = Console.ReadLine();

        Console.Write("Enter second number: ");
        string secondNumber = Console.ReadLine();

        if (isCorrect(firstNumber) && isCorrect(secondNumber))
        {
            List<int> result = SumBigIntegers(firstNumber, secondNumber);
            Console.Write("Result: ");
            PrintResult(result);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }

    static bool isCorrect(string number)
    {
        for (int i = 0; i < number.Length; i++)
        {
            if (!char.IsDigit(number[i]))
            {
                return false;
            }
        }

        return true;
    }

    static List<int> SumBigIntegers(string firstNumber, string secondNumber)
    {
        var a = firstNumber.Select(c => c - '0').ToArray();
        var b = secondNumber.Select(c => c - '0').ToArray();

        Array.Reverse(a);
        Array.Reverse(b);

        List<int> result = new List<int>(Math.Max(a.Length, b.Length));

        int carry = 0;

        for (int i = 0; i < result.Capacity; i++)
        {
            int n = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;
            carry = n / 10;
            result.Add(n % 10);
        }

        if (carry > 0)
        {
            result.Add(carry);
        }

        return result;
    }

    static void PrintResult(List<int> result)
    {
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}


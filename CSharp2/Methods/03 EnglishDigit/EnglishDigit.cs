// Problem 3. English digit

// Write a method that returns the last digit of given integer as an English word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnglishDigit
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit of the number {0} is {1}", number, GetLastDigitAsWord(number));
    }

    static string GetLastDigitAsWord(int number)
    {
        int lastDigit = number % 10;
        string lastDigitAsWord = "";

        switch (lastDigit)
        {
            case 0: lastDigitAsWord = "zero";
                break;
            case 1: lastDigitAsWord = "one";
                break;
            case 2: lastDigitAsWord = "two";
                break;
            case 3: lastDigitAsWord = "three";
                break;
            case 4: lastDigitAsWord = "four";
                break;
            case 5: lastDigitAsWord = "five";
                break;
            case 6: lastDigitAsWord = "six";
                break;
            case 7: lastDigitAsWord = "seven";
                break;
            case 8: lastDigitAsWord = "eight";
                break;
            case 9: lastDigitAsWord = "nine";
                break;
        }

        return lastDigitAsWord;
    }
}


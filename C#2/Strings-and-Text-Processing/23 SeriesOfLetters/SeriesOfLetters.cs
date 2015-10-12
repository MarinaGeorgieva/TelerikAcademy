// Problem 23. Series of letters

// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
    }
}


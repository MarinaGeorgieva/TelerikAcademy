// Problem 2. Reverse string

// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        Console.WriteLine("Reversed string is {0}", ReverseStr(s));
    }

    static string ReverseStr(string s)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}


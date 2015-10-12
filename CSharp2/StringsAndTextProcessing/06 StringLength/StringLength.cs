// Problem 6. String length

// Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with *.
// Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
    static void Main(string[] args)
    {
        Console.Write("Enter string of max 20 characters: ");
        string str = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        sb.Append(str);

        if (str.Length < 20)
        {
            sb.Append('*', 20 - str.Length);          
        }

        Console.WriteLine("Result string: {0}", sb.ToString());
    }
}

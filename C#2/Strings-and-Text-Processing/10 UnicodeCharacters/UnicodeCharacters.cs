// Problem 10. Unicode characters

// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        Console.WriteLine("String converted to sequence of unicode characters: {0}", ConvertToUnicode(str));
    }

    static string ConvertToUnicode(string input)
    {
        string result = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            result += String.Format("\\u{0:X4}", (int)input[i]);
        }

        return result;
    }
}


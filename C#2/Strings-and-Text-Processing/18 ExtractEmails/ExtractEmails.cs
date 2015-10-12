// Problem 18. Extract e-mails

// Write a program for extracting all email addresses from given text.
// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}


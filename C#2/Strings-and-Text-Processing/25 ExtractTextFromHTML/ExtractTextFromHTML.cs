// Problem 25. Extract text from HTML

// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter HTML file text: ");
        string html = Console.ReadLine();

        foreach (Match item in Regex.Matches(html, "(?<=>).*?(?=<)"))
        {
            if (!String.IsNullOrWhiteSpace(item.Value))
            {
                Console.WriteLine(item);
            }
        }
    }
}


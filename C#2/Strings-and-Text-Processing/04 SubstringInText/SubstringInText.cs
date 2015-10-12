// Problem 4. Sub-string in text

// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;

class SubstringInText
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter substring to search for: ");
        string substring = Console.ReadLine();

        Console.WriteLine("Substring \"{0}\" is contained in text {1} times", substring, CountSubstrings(text, substring));
    }

    static int CountSubstrings(string text, string substring)
    {
        int counter = 0;
        int index = 0;

        while (true)
        {
            int found = text.IndexOf(substring, index);
            if (found < 0)
            {
                break;
            }
            counter++;
            index = found + 1;
        }

        return counter;
    }
}


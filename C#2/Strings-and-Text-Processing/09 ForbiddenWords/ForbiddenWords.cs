// Problem 9. Forbidden words

// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;
using System.Linq;
using System.Text;

class ForbiddenWords
{    
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter list of forbidden words: ");
        string[] forbiddenWords = Console.ReadLine().Split(new char[] { ' ', ',', '-', ';', ':', '?', '!', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Result: {0}", ReplaceForbiddenWords(text, forbiddenWords));
    }

    static string ReplaceForbiddenWords(string text, string[] forbiddenWords)
    {
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }

        return text;
    }
}


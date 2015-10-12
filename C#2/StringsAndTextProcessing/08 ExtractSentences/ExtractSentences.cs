// Problem 8. Extract sentences

// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractSentences
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter word to search for: ");
        string word = Console.ReadLine();

        Console.WriteLine(ExtractSentence(text, word));
    }

    static string ExtractSentence(string text, string word)
    {
        List<string> result = new List<string>();
        string[] separated = text.Split(new char[] { '.', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries);
        
        for (int i = 0; i < separated.Length; i++)
        {
            string[] words = separated[i].Split(new char[] { ' ', ':', ',', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Contains(word))
            {
                result.Add(separated[i]);
            }
        }

        return string.Join(".", result);
    }
}


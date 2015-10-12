// Problem 14. Word dictionary

// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Linq;
using System.Collections.Generic;

class WordDictionary
{
    static void Main(string[] args)
    {
        SortedDictionary<string, string> myDictionary = new SortedDictionary<string, string>();
        FillDictionary(myDictionary);

        Console.Write("Enter word to search for: ");
        string word = Console.ReadLine();

        SearchForWord(myDictionary, word);

    }

    static void FillDictionary(SortedDictionary<string, string> dictionary)
    {
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");
    }

    static void SearchForWord(SortedDictionary<string, string> dictionary, string word)
    {
        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine("{0} ---> {1}", word, dictionary[word]);
        }
        else
        {
            Console.WriteLine("Word {0} is not found in the dictionary...", word);
        }
    }
}


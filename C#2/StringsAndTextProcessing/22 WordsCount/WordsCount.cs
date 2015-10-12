// Problem 22. Words count

// Write a program that reads a string from the console and lists all different words in the string 
// along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class WordsCount
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string: ");
        string str = Console.ReadLine();

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        foreach (Match word in Regex.Matches(str, @"\w+"))
        {
            dictionary[word.Value] = dictionary.ContainsKey(word.Value) ? dictionary[word.Value] + 1 : 1;
        }

        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine("{0} --> {1} times", kvp.Key, kvp.Value);
        }
    }
}


// Problem 24. Order words

// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;

class OrderWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of words, separated by spaces: ");
        string words = Console.ReadLine().ToLower();

        string[] separatedWords = words.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<string> result = new List<string>();

        foreach (string word in separatedWords)
        {
            result.Add(word);   
        }

        result.Sort();

        foreach (string word in result)
        {
            Console.WriteLine(word);
        }
    }
}


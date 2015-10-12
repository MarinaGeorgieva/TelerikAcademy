// Problem 20. Palindromes

// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Linq;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Palindromes: ");
       
        foreach (Match item in Regex.Matches(text, @"\w+"))
        {
            if (IsPalindrome(item.Value))
            {
                Console.WriteLine(item);
            }   
        }        
    }

    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}


// Problem 12. Index of letters

// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[26];

        for (char index = 'A'; index <= 'Z'; index++)
        {
            alphabet[index - 'A'] = index;
        }

        Console.Write("Enter a word: ");
        string word = Console.ReadLine().ToUpper();

        foreach (char letter in word)
        {
            for (int index = 0; index < alphabet.Length; index++)
            {
                if (alphabet[index] == letter)
                {
                    Console.WriteLine("The index of {0} in the array is {1}", letter, index);
                }
            }                
        }
    }
}


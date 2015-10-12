// Problem 21. Letters count

// Write a program that reads a string from the console and prints all different letters in the string 
// along with information how many times each letter is found.

using System;
using System.Linq;

class LettersCount
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine().ToLower();

        int[] countLetters = new int['z' - 'a' + 1];

        foreach (char c in str)
        {
            if (char.IsLetter(c))
            {
                countLetters[c - 'a']++;
            }
        }

        for (int index = 0; index < countLetters.Length; index++)
        {
            if (countLetters[index] != 0)
            {
                Console.WriteLine("{0} --> {1} times", (char)(index + 'a'), countLetters[index]);
            }
        }
    }
}


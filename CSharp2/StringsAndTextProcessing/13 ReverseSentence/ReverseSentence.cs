// Problem 13. Reverse sentence

// Write a program that reverses the words in given sentence.

using System;
using System.Linq;
using System.Text;

class ReverseSentence
{
    static string[] punctuation = { ".", ",", "?", "!", ":", ";", "-" };

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.WriteLine("Sentence with reversed words: {0}", ReverseWords(sentence));

    }

    static string ReverseWords(string sentence)
    {
        foreach (string punct in punctuation)
        {
            sentence = sentence.Replace(punct, (" " + punct));
        }

        string[] splittedSentence = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] result = new string[splittedSentence.Length];

        for (int i = 0; i < splittedSentence.Length; i++)
        {
            if (punctuation.Contains(splittedSentence[i]))
            {
                result[i] = splittedSentence[i];
            }
        }

        int wordIndex = 0;

        for (int i = splittedSentence.Length - 1; i >= 0; i--)
        {
            if (punctuation.Contains(splittedSentence[i]))
            {
                continue;
            }
            else
            {
                while (result.ElementAt(wordIndex) != null)
                {
                    wordIndex++;                    
                }
                result[wordIndex] = splittedSentence[i];
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < result.Length; i++)
        {
            if (punctuation.Contains(result[i]))
            {
                sb.Append(result[i]);
            }
            else
            {
                sb.Append(" " + result[i]);
            }
        }

        return sb.ToString().Trim();
    }
}


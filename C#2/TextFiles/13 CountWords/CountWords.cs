// Problem 13. Count words

// Write a program that reads a list of words from the file words.txt and finds how many times 
// each of the words is contained in another file test.txt.
// The result should be written in the file result.txt and the words should be sorted by the number of 
// their occurrences in descending order.
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main(string[] args)
    {
        try
        {
            string[] words = File.ReadAllLines("words.txt");
            int[] wordCount = new int[words.Length];

            using (StreamReader reader = new StreamReader("test.txt"))
            {
                string curLine;

                while ((curLine = reader.ReadLine()) != null)
                {
                    for (int index = 0; index < words.Length; index++)
                    {
                        wordCount[index] += Regex.Matches(curLine, @"\b" + words[index] + @"\b", RegexOptions.IgnoreCase).Count;
                    }
                }
            }

            Array.Sort(wordCount, words);

            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                for (int index = words.Length - 1; index >= 0; index--)
                {
                    writer.WriteLine("{0} --> {1}", words[index], wordCount[index]);
                }
            }

        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (FileLoadException fle)
        {
            Console.WriteLine(fle.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
    }
}


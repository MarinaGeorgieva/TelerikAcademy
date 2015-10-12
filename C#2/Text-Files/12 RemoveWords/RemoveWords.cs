// Problem 12. Remove words

// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class RemoveWords
{
    static void Main(string[] args)
    {
        try
        {
            string[] words = File.ReadAllLines("words.txt");
            string regex = @"\b(" + String.Join("|", words) + @")\b";       

            using (StreamWriter writer = new StreamWriter("new.txt"))
            {
                using (StreamReader reader = new StreamReader("test.txt"))
                {                    
                    string curLine;

                    while ((curLine = reader.ReadLine()) != null)
                    {
                        curLine = Regex.Replace(curLine, regex, string.Empty, RegexOptions.IgnoreCase);
                        writer.WriteLine(curLine);
                    }
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


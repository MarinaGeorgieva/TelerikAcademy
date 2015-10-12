// Problem 11. Prefix "test"

// Write a program that deletes from a text file all words that start with the prefix test.
// Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class Prefix
{
    static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter("new.txt"))
        {
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                string curLine;

                while ((curLine = reader.ReadLine()) != null)
                {
                    curLine = Regex.Replace(curLine, @"\btest\w*\b", string.Empty, RegexOptions.IgnoreCase);
                    writer.WriteLine(curLine);
                }
            }
        }
    }
}


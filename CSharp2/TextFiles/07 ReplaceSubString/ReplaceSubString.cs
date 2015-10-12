// Problem 7. Replace sub-string

// Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Text.RegularExpressions;
using System.IO;

class ReplaceSubString
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
                    curLine = Regex.Replace(curLine, "start", "finish", RegexOptions.IgnoreCase);
                    writer.WriteLine(curLine);
                }
            }
        }
    }
}


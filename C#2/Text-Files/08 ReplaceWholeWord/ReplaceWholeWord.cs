// Problem 8. Replace whole word

// Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
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
                    curLine = Regex.Replace(curLine, @"\bstart\b", "finish", RegexOptions.IgnoreCase);
                    writer.WriteLine(curLine);
                }
            }
        }
    }
}


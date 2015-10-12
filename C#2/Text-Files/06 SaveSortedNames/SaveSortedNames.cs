// Problem 6. Save sorted names

// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;

class SaveSortedNames
{
    static void Main(string[] args)
    {
        List<string> result = new List<string>();

        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string curLine = reader.ReadLine();
            result.Add(curLine);

            while (curLine != null)
            {
                curLine = reader.ReadLine();
                if (curLine == null)
                {
                    break;
                }
                result.Add(curLine);
            }
        }

        result.Sort();

        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            foreach (var line in result)
            {
                writer.WriteLine(line);
            }
        }
    }
}


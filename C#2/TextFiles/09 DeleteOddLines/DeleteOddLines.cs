// Problem 9. Delete odd lines

// Write a program that deletes from given text file all odd lines.
// The result should be in the same file.

using System;
using System.IO;

class DeleteOddLines
{
    static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter("new.txt"))
        {
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                int curLineNumber = 0;
                string curLine;

                while ((curLine = reader.ReadLine()) != null)
                {
                    curLineNumber++;
                    if (curLineNumber % 2 == 0)
                    {
                        writer.WriteLine(curLine);
                    }
                }
            }
        }

        using (StreamReader reader = new StreamReader("new.txt"))
        {
            using (StreamWriter writer = new StreamWriter("test.txt"))
            {
                string curLine;

                while ((curLine = reader.ReadLine()) != null)
                {
                    writer.WriteLine(curLine);
                }
            }
        }
    }
}


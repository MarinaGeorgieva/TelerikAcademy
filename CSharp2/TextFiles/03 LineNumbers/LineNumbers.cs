// Problem 3. Line numbers

// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter("new.txt"))
        {
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                int curLineNumber = 0;
                string curLine = reader.ReadLine();

                while (curLine != null)
                {
                    curLineNumber++;
                    writer.WriteLine(curLineNumber + ": " + curLine);
                    curLine = reader.ReadLine();
                }                
            }
        }

        Console.WriteLine("New file succesfully filled with data!");
    }
}


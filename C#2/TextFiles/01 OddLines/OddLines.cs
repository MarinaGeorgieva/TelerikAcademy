// Problem 1. Odd lines

// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("test.txt"))
        {
            int curLineNumber = 0;
            string curLine = reader.ReadLine();

            while (curLine != null)
            {
                curLineNumber++;
                if (curLineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", curLineNumber, curLine);
                }
                curLine = reader.ReadLine();
            }
        }
    }
}


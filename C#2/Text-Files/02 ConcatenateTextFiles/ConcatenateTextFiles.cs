// Problem 2. Concatenate text files

// Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter("new.txt"))
        {
            using (StreamReader reader = new StreamReader("file1.txt"))
            {
                string curLine = reader.ReadLine();

                while (curLine != null)
                {
                    writer.WriteLine(curLine);
                    curLine = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader("file2.txt"))
            {
                string curLine = reader.ReadLine();

                while (curLine != null)
                {
                    writer.WriteLine(curLine);
                    curLine = reader.ReadLine();
                }
            }
        }

        Console.WriteLine("New file succesfully filled with data!");
    }
}


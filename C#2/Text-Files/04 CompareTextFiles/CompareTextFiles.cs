// Problem 4. Compare text files

// Write a program that compares two text files line by line and prints the number of lines that are the same and 
// the number of lines that are different.
// Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main(string[] args)
    {
        using (StreamReader firstReader = new StreamReader("file1.txt"))
        {
            using (StreamReader secondReader = new StreamReader("file2.txt"))
            {
                string firstFileLine = firstReader.ReadLine();
                string secondFileLine = secondReader.ReadLine();

                int countEqual = 0;
                int countDifferent = 0;

                while (firstFileLine != null && secondFileLine != null)
                {
                    if (firstFileLine.CompareTo(secondFileLine) == 0)
                    {
                        countEqual++;
                    }
                    else
                    {
                        countDifferent++;
                    }

                    firstFileLine = firstReader.ReadLine();
                    secondFileLine = secondReader.ReadLine();
                }

                Console.WriteLine("Equal lines --> {0}", countEqual);
                Console.WriteLine("Different lines --> {0}", countDifferent);
            }
        }
    }
}


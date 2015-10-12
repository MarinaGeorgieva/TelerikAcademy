// Problem 10. Extract text from XML

// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text;

class ExtractTextFromXML
{
    static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {                
                string curLine = reader.ReadLine();
                StringBuilder result = new StringBuilder();

                while (curLine != null)
                {
                    for (int i = 1; i < curLine.Length; i++)
                    {
                        if (curLine[i - 1] == '>')
                        {
                            while (curLine[i] != '<')
                            {
                                result.Append(curLine[i]);
                                i++;
                            }

                            if (result.ToString() != string.Empty)
                            {
                                writer.WriteLine(result.ToString());
                                result.Clear();
                            }
                        }
                    }
                    curLine = reader.ReadLine();
                }  
            }
        }
    }
}


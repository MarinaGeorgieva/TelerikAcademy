// Problem 5. Parse tags

// You are given a text. Write a program that changes the text in all regions surrounded by the tags 
// <upcase> and </upcase> to upper-case.
// The tags cannot be nested.

using System;
using System.Linq;
using System.Text;

class ParseTags
{
    static string start = "<upcase>";
    static string end = "</upcase>";

    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Parsed text: {0}", ParseText(text));
    }

    static string ParseText(string text)
    {
        StringBuilder sb = new StringBuilder();

        int index = 0;

        while (true)
        {
            int foundStart = text.IndexOf(start, index);
            int foundEnd = text.IndexOf(end, index);

            if (foundStart < 0 && foundEnd < 0)
            {
                break;
            }
            sb.Append(text.Substring(index, foundStart - index));

            for (int i = foundStart + start.Length; i < foundEnd; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    sb.Append(char.ToUpper(text[i]));
                }
                else
                {
                    sb.Append(text[i]);
                }
            }

            index = foundEnd + end.Length;

        }

        sb.Append(text.Substring(index, text.Length - index));

        return sb.ToString();
    }
}

// Problem 15. Replace tags

// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> 
// with corresponding tags [URL=…]…/URL].

using System;
using System.Linq;
using System.Text;

class ReplaceTags
{
    static void Main(string[] args)
    {
        Console.Write("Enter HTML document text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Replaced text: {0}", ReplaceText(text));
    }

    static string ReplaceText(string text)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            sb.Append(text[i]);
        }

        sb.Replace("<a href=\"", "[URL=").Replace("\">", "]").Replace("</a>", "[/URL]");
        return sb.ToString();
    }
}


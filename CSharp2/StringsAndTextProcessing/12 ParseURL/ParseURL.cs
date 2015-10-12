// Problem 12. Parse URL

// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
// and extracts from it the [protocol], [server] and [resource] elements.

using System;

class ParseURL
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter URL in the format: [protocol]://[server]/[resource]: ");
        string url = Console.ReadLine();

        Uri myUri = new Uri(url);

        Console.WriteLine("[protocol] = {0}", myUri.Scheme);
        Console.WriteLine("[server] = {0}", myUri.Authority);
        Console.WriteLine("[resource] = {0}", myUri.AbsolutePath);
    } 
}


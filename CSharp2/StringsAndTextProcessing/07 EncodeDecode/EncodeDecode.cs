// Problem 7. Encode/decode

// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters.
// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string 
// with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class EncodeDecode
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string inputText = Console.ReadLine();

        Console.Write("Enter cipher key: ");
        string cipherKey = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("\tMenu");
        Console.WriteLine("1. Encode");
        Console.WriteLine("2. Decode\n\n");

        byte choice = 0;

        while (choice == 0)
        {
            Console.Write("Enter your choice: ");
            choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Encoded text is: {0}", Encode(inputText, cipherKey));
                    break;
                case 2:
                    Console.WriteLine("Decoded text is: {0}", Decode(inputText, cipherKey));
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please, enter 1 or 2...");
                    choice = 0;
                    break;
            }
        }
    }

    static string Encode(string inputText, string cipherKey)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < inputText.Length; i++)
        {
            sb.Append((char)(inputText[i] ^ cipherKey[i % cipherKey.Length]));
        }

        return sb.ToString();
    }

    static string Decode(string encodedText, string cipherKey)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < encodedText.Length; i++)
        {
            sb.Append((char)(encodedText[i] ^ cipherKey[i % cipherKey.Length]));
        }

        return sb.ToString();
    }
}


// Problem 1. Say Hello

// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SayHello
{
    static void Main(string[] args)
    {
        GreetUser();
    }

    public static void GreetUser()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}


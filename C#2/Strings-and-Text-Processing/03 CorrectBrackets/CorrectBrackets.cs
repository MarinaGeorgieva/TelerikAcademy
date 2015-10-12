// Problem 3. Correct brackets

// Write a program to check if in a given expression the brackets are put correctly.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static void Main(string[] args)
    {
        Console.Write("Enter expression: ");
        string expression = Console.ReadLine();

        Console.WriteLine("Brackets in expression are correct: {0}", CheckBrackets(expression));
    }

    static bool CheckBrackets(string expression)
    {
        if (expression.IndexOf('(') > expression.IndexOf(')'))
        {
            return false; 
        }
        else
        {
            return true;
        }
    }
}


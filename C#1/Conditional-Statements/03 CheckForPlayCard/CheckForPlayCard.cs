// Problem 3. Check for a Play Card

// Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
// Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;

class CheckForPlayCard
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a character: ");
        string character = Console.ReadLine();

        if (character == "2" || character == "3" || character == "4" || character == "5" || character == "6"
            || character == "7" || character == "8" || character == "9" || character == "10" || character == "A"
            || character == "K" || character == "Q" || character == "J")
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        
    }
}


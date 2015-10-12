// Problem 9. Play with Int, Double and String

// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

using System;

class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type: ");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("Please enter an int: ");
                int inputInt = int.Parse(Console.ReadLine());
                inputInt += 1;
                Console.WriteLine("Result: {0}", inputInt);
                break;
            case 2: Console.WriteLine("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                inputDouble += 1;
                Console.WriteLine("Result: {0}", inputDouble);
                break;
            case 3: Console.WriteLine("Please enter a string: ");
                string inputString = Console.ReadLine();
                inputString += "*";
                Console.WriteLine("Result: {0}", inputString);
                break;
            default: Console.WriteLine("Invalid choice! Please enter 1, 2 or 3!");
                break;
        }
    }
}


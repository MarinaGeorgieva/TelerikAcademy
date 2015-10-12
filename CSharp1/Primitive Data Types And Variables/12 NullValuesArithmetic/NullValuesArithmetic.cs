// Problem 12. Null Values Arithmetic

// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? nullInteger = null;
        double? nullDouble = null;

        Console.WriteLine("Integer with null value: " + nullInteger);
        Console.WriteLine("Double with null value: " + nullDouble);

        nullInteger = 7;
        nullDouble = 7.45;

        Console.WriteLine("New value of double: " + nullInteger);
        Console.WriteLine("New value of double: " + nullDouble);
    }
}


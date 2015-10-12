// Problem 8. Isosceles Triangle

/* Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©

*/
using System;

class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        char copyright = '\u00A9';
        
        Console.WriteLine("    " + copyright);
        Console.WriteLine("   " + copyright + " " + copyright);
        Console.WriteLine("  " + copyright + "   " + copyright);
        Console.WriteLine(" " + copyright + " " + copyright + " " + copyright + " " + copyright);

    }
}


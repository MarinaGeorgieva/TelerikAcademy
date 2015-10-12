// Problem 14. Modify a Bit at Given Position

// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary 
// representation of n while preserving all other bits in n.

using System;

class ModifyBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter a position: ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a bit value v (0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        int result = 0;
        if (v == 0)
        {
            int mask = ~(1 << position);
            result = (int)number & mask;
        }
        else if (v == 1)
        {
            int mask = 1 << position;
            result = (int)number | mask;
        }
        Console.WriteLine("The number {0} after changing bit #{1} to {2} is the number {3}", number, position, v, result);
        Console.WriteLine("Binary representation: ");
        Console.WriteLine("{0} ---> {1}", Convert.ToString(number, 2).PadLeft(32, '0'), Convert.ToString(result, 2).PadLeft(32, '0'));
            
    }
}


// Problem 12.* Zero Subset

// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.

using System;

class ZeroSubset
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter fourth number: ");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter fifth number: ");
        int e = int.Parse(Console.ReadLine());

        int count = 0;

        if (a == 0) {
            count++;
            Console.WriteLine("{0} = 0", a);
        }
        if (b == 0)
        {
            count++;
            Console.WriteLine("{0} = 0", b);
        }
        if (c == 0)
        {
            count++;
            Console.WriteLine("{0} = 0", c);
        }
        if (d == 0)
        {
            count++;
            Console.WriteLine("{0} = 0", d);
        }
        if (e == 0)
        {
            count++;
            Console.WriteLine("{0} = 0", e);
        }

        if (a + b == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", a, b);
        }
        if (a + c == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", a, c);
        }
        if (a + d == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", a, d);
        }
        if (a + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", a, e);
        }
        if (b + c == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", b, c);
        }
        if (b + d == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", b, d);
        }
        if (b + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", b, e);
        }
        if (c + d == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", c, d);
        }
        if (c + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", c, e);
        }
        if (d + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} = 0", d, e);
        }

        if (a + b + c == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
        }
        if (a + b + d == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
        }
        if (a + b + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
        }
        if (a + c + d == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
        }
        if (a + c + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
        }
        if (a + d + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
        }
        if (b + c + d == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
        }
        if (b + c + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
        }
        if (b + d + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
        }
        if (c + d + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
        }

        if (a + b + c + d == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
        }
        if (a + b + c + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
        }
        if (a + b + d + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
        }
        if (a + c + d + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
        }
        if (b + c + d + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
        }        

        if (a + b + c + d + e == 0)
        {
            count++;
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }

        if (count == 0)
        {
            Console.WriteLine("There are no zero subsets ");
        }
    }
}


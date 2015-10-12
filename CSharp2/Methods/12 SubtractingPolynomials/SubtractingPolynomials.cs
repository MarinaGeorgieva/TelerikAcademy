// Problem 12. Subtracting polynomials

// Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubtractingPolynomials
{
    static void Main(string[] args)
    {
        Console.Write("Enter first polynomial degree: ");
        int firstDegree = int.Parse(Console.ReadLine());

        double[] firstPoly = new double[firstDegree + 1];

        for (int i = 0; i < firstPoly.Length; i++)
        {
            Console.Write("Enter x^{0}: ", i);
            firstPoly[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Enter second polynomial degree: ");
        int secondDegree = int.Parse(Console.ReadLine());

        double[] secondPoly = new double[secondDegree + 1];

        for (int i = 0; i < secondPoly.Length; i++)
        {
            Console.Write("Enter x^{0}: ", i);
            secondPoly[i] = double.Parse(Console.ReadLine());
        }

        PrintPoly(firstPoly);
        Console.WriteLine("-");
        PrintPoly(secondPoly);
        Console.WriteLine("=");
        Subtract(firstPoly, secondPoly);
        Console.WriteLine();

        PrintPoly(firstPoly);
        Console.WriteLine("*");
        PrintPoly(secondPoly);
        Console.WriteLine("=");
        Multiply(firstPoly, secondPoly);
    }

    static void Subtract(double[] firstPoly, double[] secondPoly)
    {
        int lengthBigger = Math.Max(firstPoly.Length, secondPoly.Length);
        bool isFirstBigger = firstPoly.Length > secondPoly.Length;
        bool isZero = true;

        double[] resultPoly = new double[lengthBigger];

        for (int index = 0; index < resultPoly.Length; index++)
        {
            if (index < firstPoly.Length && index < secondPoly.Length)
            {
                resultPoly[index] = firstPoly[index] - secondPoly[index];
                if (resultPoly[index] != 0)
                {
                    isZero = false;
                }
            }
            else if (isFirstBigger)
            {
                resultPoly[index] = firstPoly[index];
            }
            else
            {
                resultPoly[index] = -secondPoly[index];
            }
        }

        if (isZero)
        {
            Console.WriteLine("0");
        }
        else
        {
            PrintPoly(resultPoly);
        }
    }

    static void Multiply(double[] firstPoly, double[] secondPoly)
    {
        double[] resultPoly = new double[firstPoly.Length + secondPoly.Length - 1];

        for (int i = 0; i < firstPoly.Length; i++)
        {
            for (int j = 0; j < secondPoly.Length; j++)
            {
                resultPoly[i + j] += (firstPoly[i] * secondPoly[j]);
            }
        }

        PrintPoly(resultPoly);
    }

    static void PrintPoly(double[] poly)
    {
        for (int i = 0; i < poly.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("{0} + ", poly[i]);
            }
            else if (poly[i] != 0 && i != poly.Length - 1)
            {
                if (poly[i + 1] >= 0)
                {
                    Console.Write("{0}x^{1} + ", poly[i], i);
                }
                else
                {
                    Console.Write("{0}x^{1} ", poly[i], i);
                }
            }
            else
            {
                Console.Write("{0}x^{1} ", poly[i], i);
            }
        }
        Console.WriteLine();
    }
}


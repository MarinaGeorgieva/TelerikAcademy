// Problem 19.* Permutations of set

// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Permutations
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int[] arrayN = new int[n];

        for (int index = 0; index < arrayN.Length; index++)
        {
            arrayN[index] = index + 1;
        }

        int counter;

        do
        {
            counter = 1;
            if (CheckElements(arrayN))
            {
                Print(arrayN);
            }

            for (int i = arrayN.Length - 1; i >= 0; i--)
            {
                arrayN[i] += counter;

                if (arrayN[i] <= n)
                {
                    counter = 0;
                    break;
                }

                arrayN[i] = 1;
                counter = 1;
            }

        } while (counter != 1);

    }

    public static bool CheckElements(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static void Print(int[] array)
    {
        Console.Write("{");
        for (int index = 0; index < array.Length; index++)
        {
            if (index != array.Length - 1)
            {
                Console.Write(array[index] + ",");
            }
            else
            {
                Console.Write(array[index]);
            }
        }
        Console.WriteLine("}");
    }
}



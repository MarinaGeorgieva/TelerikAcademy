// Problem 21.* Combinations of set

// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Combinations
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int[] arrayK = new int[k];

        for (int index = 0; index < arrayK.Length; index++)
        {
            arrayK[index] = index + 1;
        }

        int counter;

        do
        {
            counter = 1;
            if (CheckAscendingOrder(arrayK))
            {
                Print(arrayK);
            }

            for (int i = arrayK.Length - 1; i >= 0; i--)
            {
                arrayK[i] += counter;

                if (arrayK[i] <= n)
                {
                    counter = 0;
                    break;
                }

                arrayK[i] = 1;
                counter = 1;
            }

        } while (counter != 1);

    }

    public static bool CheckAscendingOrder(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] >= array[j])
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



﻿/* Problem 5. Generic class

Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
Check all input parameters to avoid accessing elements at invalid positions.

Problem 6. Auto-grow

Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

Problem 7. Min and Max

Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
You may need to add a generic constraints for the type T.  */


namespace DefiningClassesProblem5_7
{
    using System;

    class GenericListTest
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(6);

            for (int i = 0; i < 6; i++)
            {
                list.Add(i + 1); 
            }
            Console.WriteLine(list);

            list.InsertAt(3, 28);
            Console.WriteLine(list);

            
        }
    }
}

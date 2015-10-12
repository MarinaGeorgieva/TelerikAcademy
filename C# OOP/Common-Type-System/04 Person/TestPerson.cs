// Problem 4. Person class

// Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
// Override ToString() to display the information of a person and if age is not specified – to say so.
// Write a program to test this functionality.

namespace _04_Person
{
    using System;

    public class TestPerson
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Pesho", 21);
            Person secondPerson = new Person("Gosho", null);
            Person thirdPerson = new Person("Ivan");

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
            Console.WriteLine(thirdPerson);
        }
    }
}

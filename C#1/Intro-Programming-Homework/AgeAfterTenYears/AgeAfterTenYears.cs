// Problem 15.* Age after 10 Years
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate: ");
            var birthday = DateTime.Parse(Console.ReadLine());
            int age = DateTime.Today.Year - birthday.Year;
            if (birthday > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            Console.WriteLine("You are now " + age + " years old");
            Console.WriteLine("In 10 years you will be " + (age + 10) + " years old");
        }
    }
}

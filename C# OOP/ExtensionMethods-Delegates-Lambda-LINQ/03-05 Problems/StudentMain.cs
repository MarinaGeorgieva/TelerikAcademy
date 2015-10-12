// Problem 3. First before last

// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
// Use LINQ query operators.

// Problem 4. Age range

// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

// Problem 5. Order students

// Using the extension methods OrderBy() and ThenBy() with lambda expressions 
// sort the students by first name and last name in descending order.
// Rewrite the same with LINQ.

namespace _03_04_05_Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentMain
    {
        static void Main(string[] args)
        {
            Student[] students = {new Student("Petar", "Petrov", 15), new Student("Ivan", "Todorov", 21), 
                                 new Student("Georgi", "Nikolov", 18), new Student("Yavor", "Georgiev", 19), 
                                 new Student("Sasho", "Hristov", 25), new Student("Kiril", "Mitov", 24), 
                                 new Student("Georgi", "Georgiev", 17)};

            //all students whose first name is before its last name alphabetically
            var firstBeforeLast = FirstBeforeLastName(students);

            foreach (Student student in firstBeforeLast)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //the first name and last name of all students with age between 18 and 24.
            var ageRange = StudentsInAgeRange(students, 18, 24);

            foreach (Student student in ageRange)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            //  sort the students by first name and last name in descending order with OrderBy() and ThenBy() 
            // with lambda expressions
            var sortedWithLambda = students.OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);

            foreach (Student student in sortedWithLambda)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //  sort the students by first name and last name in descending order with OrderBy() and ThenBy() 
            // with LINQ expressions
            var sortedWithLinq =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (Student student in sortedWithLinq)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }

        public static IEnumerable<Student> FirstBeforeLastName(Student[] students)
        {
            var result =
                from student in students
                where student.FirstName.ElementAt(0) < student.LastName.ElementAt(0)
                select student;

            return result;
        }

        public static IEnumerable<Student> StudentsInAgeRange(Student[] students, int minAge, int maxAge)
        {
            var result =
                from student in students
                where student.Age >= minAge && student.Age <= maxAge
                select student;

            return result;
        }
    }
}

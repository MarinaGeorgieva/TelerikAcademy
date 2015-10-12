// Problem 2. Students and workers

// Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human 
// and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay 
// and a method MoneyPerHour() that returns money earned per hour by the worker. 
// Define the proper constructors and properties for this hierarchy.

// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// Initialize a list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.

namespace _02_StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsAndWorkersMain
    {
        static void Main(string[] args)
        {
            // Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            List<Student> students = new List<Student>
            {
                new Student("Kiril", "Georgiev", 10),
                new Student("Boris", "Hristov", 11),
                new Student("Ani", "Dimitrova", 9),
                new Student("Petur", "Petrov", 6),
                new Student("Maria", "Hristova", 10),
                new Student("Zornitsa", "Aleksandrova", 12),
                new Student("Sasho", "Genov", 7),
                new Student("Gergana", "Ivanova", 11),
                new Student("Nikola", "Damyanov", 8),
                new Student("Todor", "Nikolov", 3),
            };

            var orderByGrade = students.OrderBy(student => student.Grade);

            foreach (Student student in orderByGrade)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker> 
            {
                new Worker("Simeon", "Kolev", 200, 8),
                new Worker("Iliya", "Trendafilov", 250, 8),
                new Worker("Ognyan", "Aleksov", 220.50, 8),
                new Worker("Plamen", "Petkov", 300, 8),
                new Worker("Zdravka", "Stoeva", 120, 4),
                new Worker("Rumen", "Panchev", 150.25, 4),
                new Worker("Yanko", "Yanev", 180, 6),
                new Worker("Lubima", "Zoeva", 130.50, 8),
                new Worker("Temenujka", "Koleva", 155, 8),
                new Worker("Pavel", "Pavlov", 215, 6),
            };

            var orderByMoneyPerHour = workers.OrderByDescending(worker => worker.MoneyPerHour());

            foreach (Worker worker in orderByMoneyPerHour)
            {
                Console.WriteLine("{0} \nMoney per hour: {1} \n", worker, worker.MoneyPerHour());   
            }

            // Merge the lists and sort them by first name and last name.
            List<Human> studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            var orderByFirstAndLastName = studentsAndWorkers.OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName);

            foreach (var human in orderByFirstAndLastName)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
            Console.WriteLine();

        }
    }
}

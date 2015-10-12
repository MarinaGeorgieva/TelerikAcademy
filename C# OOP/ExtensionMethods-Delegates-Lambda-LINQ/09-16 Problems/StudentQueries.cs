/* Problem 9. Student groups

Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
 * 
Problem 10. Student groups extensions

Implement the previous using the same query expressed with extension methods.
 * 
Problem 11. Extract students by email

Extract all students that have email in abv.bg.
Use string methods and LINQ.
 * 
Problem 12. Extract students by phone

Extract all students with phones in Sofia.
Use LINQ.
 * 
Problem 13. Extract students by marks

Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
Use LINQ.
 * 
Problem 14. Extract students with two marks

Write down a similar program that extracts the students with exactly two marks "2".
Use extension methods.
 * 
Problem 15. Extract marks

Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
 * 
 Problem 16.* Groups

Create a class Group with properties GroupNumber and DepartmentName.
Introduce a property GroupNumber in the Student class.
Extract all students from "Mathematics" department.
Use the Join operator. 
 * 
Problem 18. Grouped by GroupNumber

Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
Use LINQ.

Problem 19. Grouped by GroupName extensions

Rewrite the previous using extension methods.
 */

namespace _09_16_Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentQueries
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() 
            { 
                new Student("Pesho", "Peshov", "123406", "0854373434", "pesho@abv.bg", new List<double> {4, 5, 4.50}, new Group(2, "Mathematics")),
                new Student("Georgi", "Ivanov", "123409", "02543533", "gosho@abv.bg", new List<double> {6, 5.50, 4.50}, new Group(3, "Physics")),
                new Student("Nikola", "Dimitrov", "123411", "0894532313", "ndimitrov@yahoo.com", new List<double> {3.50, 4, 2, 2}, new Group(2, "Informatics")),
                new Student("Kiril", "Petrov", "123406", "0854343212", "kircho@abv.bg", new List<double> {5, 6, 5.50}, new Group(2, "Mathematics")),
                new Student("Maria", "Hristova", "123406", "02865782", "mariika@yahoo.com", new List<double> {4.50, 5.25, 5}, new Group(1, "Mathematics")),
            };

            // only the students that are from group number 2, order the students by first name, with linq
            Console.WriteLine("Only the students that are from group number 2 with linq");
            var studentsFromGroupTwoWithLinq =
                from student in students
                where student.GroupN.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (Student student in studentsFromGroupTwoWithLinq)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // only the students that are from group number 2, order the students by first name, with lambda
            Console.WriteLine("Only the students that are from group number 2 with lambda");
            var studentsFromGroupTwoWithLambda = students.Where(student => student.GroupN.GroupNumber == 2)
                .OrderBy(student => student.FirstName);

            foreach (Student student in studentsFromGroupTwoWithLambda)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // all students that have email in abv.bg with linq
            Console.WriteLine("All students that have email in abv.bg");
            var extractStudentsByEmail =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;

            foreach (Student student in extractStudentsByEmail)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //all students with phones in Sofia with linq
            Console.WriteLine("All students with phones in Sofia");
            var extractStudentsByPhone =
                from student in students
                where student.Tel.StartsWith("02")
                select student;

            foreach (Student student in extractStudentsByPhone)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks, with linq
            Console.WriteLine("All students that have at least one mark Excellent (6)");
            var extractStudentsByMark =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks};

            foreach (var student in extractStudentsByMark)
            {
                Console.WriteLine("Full name: {0} \nMarks: {1}\n", student.FullName, string.Join(", ", student.Marks));
            }
            Console.WriteLine();

            //the students with exactly two marks "2" with lambda
            Console.WriteLine("The students with exactly two marks 2");
            var extractStudentsWithTwoMarks = students.Where(student => student.Marks.FindAll(mark => mark == 2).Count == 2)
                .Select(student => new { 
                    FullName = student.FirstName + " " + student.LastName, 
                    Marks = student.Marks });

            foreach (var student in extractStudentsWithTwoMarks)
            {
                Console.WriteLine("Full name: {0} \nMarks: {1}\n", student.FullName, string.Join(", ", student.Marks));
            }
            Console.WriteLine();

            //all Marks of the students that enrolled in 2006
            Console.WriteLine("All Marks of the students that enrolled in 2006");
            var extractMarks = students.Where(student => student.FN.Substring(4, 2) == "06")
                .Select(student => student.Marks);

            foreach (var mark in extractMarks)
            {
                Console.WriteLine("{0}", string.Join(", ", mark));
            }
            Console.WriteLine();

            //All students from "Mathematics" department           
            Group group1 = new Group(1, "Informatics");
            Group group2 = new Group(2, "Mathematics");
            Group group3 = new Group(3, "Physics");

            List<Group> listOfGroups = new List<Group> {group1, group2, group3};

             Console.WriteLine("All students from Mathematics department");
            var extractStudentsByDepartment =
                from someGroup in listOfGroups
                where someGroup.DepartmentNumber == "Mathematics"
                join student in students on someGroup.DepartmentNumber equals student.GroupN.DepartmentNumber
                select student;

            foreach (Student student in extractStudentsByDepartment)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //students grouped by GroupNumber with linq
            Console.WriteLine("Students grouped by GroupNumber with linq");

            var groupsWithLinq =
                from student in students
                group student by student.GroupN.GroupNumber;

            List<string> resultWithLinq = new List<string>();

            foreach (var someGroup in groupsWithLinq)
            {
                resultWithLinq.Add(string.Format("group {0}", someGroup.ElementAt(0).GroupN.GroupNumber)); 
            }

            foreach (var element in resultWithLinq)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            //students grouped by GroupNumber with lambda
            Console.WriteLine("Students grouped by GroupNumber with lambda");

            var groupsWithLambda = students.GroupBy(student => student.GroupN.GroupNumber);

            List<string> resultWithLambda = new List<string>();

            foreach (var someGroup in groupsWithLambda)
            {
                resultWithLambda.Add(string.Format("group {0}", someGroup.ElementAt(0).GroupN.GroupNumber));
            }

            foreach (var element in resultWithLambda)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
}

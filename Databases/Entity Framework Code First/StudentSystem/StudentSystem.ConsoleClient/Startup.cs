namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;
    using StudentSystem.Models;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

            var db = new StudentSystemDbContext();

            Console.WriteLine("Homeworks count before inserting: {0}", db.Homeworks.Count());
            Console.WriteLine("Courses count before inserting: {0}", db.Courses.Count());
            Console.WriteLine("Students count before inserting: {0}", db.Students.Count());
            
            var student = new Student
            {
                FirstName = "David",
                LastName = "Nielsen",
                Age = 24,
                Number = 31813
            };

            var course = new Course
            {
                Name = "Databases",
                Description = "Introduction to Databases"
            };

            var homework = new Homework
            {
                Content = "Entity Framework Code First Homework",
                TimeSent = DateTime.Now
            };

            course.Homeworks.Add(homework);
            student.Courses.Add(course);
            student.Homeworks.Add(homework);
                        
            db.Homeworks.Add(homework);
            db.Courses.Add(course);
            db.Students.Add(student);
            db.SaveChanges();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Homeworks count after inserting: {0}", db.Homeworks.Count());
            Console.WriteLine("Courses count after inserting: {0}", db.Courses.Count());
            Console.WriteLine("Students count after inserting: {0}", db.Students.Count());
        }
    }
}

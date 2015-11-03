namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    using StudentSystem.Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Mary",
                    LastName = "Cole",
                    Age = 23,
                    Number = 14534
                },
                new Student
                {
                    FirstName = "Thomas",
                    LastName = "Jackson",
                    Age = 18,
                    Number = 10348
                },
                new Student
                {
                    FirstName = "Christopher",
                    LastName = "Cowan",
                    Age = 24,
                    Number = 23260
                },
                new Student
                {
                    FirstName = "Sandra",
                    LastName = "Wilson",
                    Age = 26,
                    Number = 29540
                },
                new Student
                {
                    FirstName = "Anthony",
                    LastName = "Williams",
                    Age = 21,
                    Number = 26492
                },
                new Student
                {
                    FirstName = "Robert",
                    LastName = "Harris",
                    Age = 24,
                    Number = 23212
                },
                new Student
                {
                    FirstName = "Andrew",
                    LastName = "Warner",
                    Age = 25,
                    Number = 10273
                },
                new Student
                {
                    FirstName = "Ema",
                    LastName = "Walker",
                    Age = 19,
                    Number = 34016
                },
                new Student
                {
                    FirstName = "Rachel",
                    LastName = "Hall",
                    Age = 20,
                    Number = 56976
                }
            };
            students.ForEach(student => context.Students.Add(student));

            var courses = new List<Course>
            {
                new Course
                {
                    Name = "C# Part 1",
                    Description = "Introduction to C# 1"
                },
                new Course
                {
                    Name = "C# Part 2",
                    Description = "Introduction to C# 2"
                },
                new Course
                {
                    Name = "OOP",
                    Description = "Introduction to OOP"
                },
                new Course
                {
                    Name = "HQC",
                    Description = "Introduction to High Quality Code"
                }                
            };
            courses.ForEach(course => context.Courses.Add(course));

            var newStudent = new Student
            {
                FirstName = "David",
                LastName = "Nielsen",
                Age = 24,
                Number = 31813
            };

            var newCourse = new Course
            {
                Name = "Databases",
                Description = "Introduction to Databases"
            };

            var homework = new Homework
            {
                Content = "Entity Framework Code First Homework",
                Deadline = DateTime.Now
            };

            newCourse.Homeworks.Add(homework);
            newStudent.Courses.Add(newCourse);
            newStudent.Homeworks.Add(homework);

            context.Homeworks.Add(homework);
            context.Courses.Add(newCourse);
            context.Students.Add(newStudent);
        }
    }
}

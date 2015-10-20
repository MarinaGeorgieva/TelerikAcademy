﻿namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;
        private string teacherName;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public Course(string name, string teacherName) 
            : this(name)
        {
            this.TeacherName = teacherName;
        }

        public Course(string name, string teacherName, ICollection<string> students)
            : this(name, teacherName)
        {
            if (students != null)
            {
                foreach (var student in students)
                {
                    this.Students.Add(student);
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Course name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Teacher name cannot be null or empty");
                }

                this.teacherName = value;
            }
        }

        public ICollection<string> Students { get; set; }

        public void AddStudents(params string[] students) 
        {
            foreach (var student in students)
            {
                if (string.IsNullOrWhiteSpace(student))
                {
                    throw new ArgumentException("Student cannot be null or empty");
                }

                this.Students.Add(student);
            }
        }        

        public override string ToString()
        {
            string courseType = this.GetType().Name;
            string courseName = string.Format("Name = {0}", this.Name);
            string teacherName = string.Format("Teacher = {0}", this.TeacherName);
            string students = string.Empty;

            if (this.Students.Count > 0)
            {
                students = string.Format("Students = {0}", this.GetStudentsAsString());
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine(courseType);
            result.AppendLine(courseName);
            result.AppendLine(teacherName);
            result.AppendLine(students);

            return result.ToString().Trim();
        }

        private string GetStudentsAsString()
        {
            string students = "{ " + string.Join(", ", this.Students) + " }";
            return students;
        }
    }
}
namespace _01_SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : IComment
    {
        private string textIdentifier;
        private List<Teacher> teachers;
        private List<Student> students;

        public Class(string textIdentifier, List<Teacher> teachers, List<Student> students)
        {
            this.TextIdentifier = textIdentifier;
            this.Teachers = teachers;
            this.Students = students;
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Text identifier cannot be null or empty");
                }

                this.textIdentifier = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public string Comment { get; private set; }

        public void AddComment(string comment)
        {
            this.Comment = comment;
        }
    }
}

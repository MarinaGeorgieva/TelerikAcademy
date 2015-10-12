namespace School
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private const int MinValidId = 10000;
        private const int MaxValidId = 99999;
        
        private string firstName;
        private string lastName;
        private int id;
        private ICollection<Course> courses;

        public Student(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.courses = new List<Course>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < Student.MinValidId || Student.MaxValidId < value)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("Student id must be between {0} and {1}", Student.MinValidId, Student.MaxValidId));
                }

                this.id = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public void SignCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            this.courses.Add(course);
            if (!course.Students.Contains(this))
            {
                course.AddStudent(this);
            }
        }

        public void UnsignCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            this.courses.Remove(course);
            if (course.Students.Contains(this))
            {
                course.RemoveStudent(this);
            }
        }
    }
}

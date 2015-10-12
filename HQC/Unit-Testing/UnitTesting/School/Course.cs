namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsCount = 30;
        
        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();            
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
                    throw new ArgumentNullException("Course name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
        } 

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.students.Count >= Course.MaxStudentsCount)
            {
                throw new ArgumentOutOfRangeException("Students must be less than 30");
            }

            if(this.students.Contains(student))
            {
                throw new InvalidOperationException("The student is already signed for this course");
            }

            this.students.Add(student);
            student.SignCourse(this);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null.");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("The student is not signed for this course.");
            }

            this.students.Remove(student);
            student.UnsignCourse(this);
        }
    }
}

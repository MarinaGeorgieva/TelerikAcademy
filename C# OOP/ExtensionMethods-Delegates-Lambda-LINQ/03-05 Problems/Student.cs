namespace _03_04_05_Problem
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("First name cannot be null or empty string");
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
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Last name cannot be null or empty string");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be positive number");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}

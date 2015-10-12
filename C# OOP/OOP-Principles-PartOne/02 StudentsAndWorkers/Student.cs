namespace _02_StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Grade cannot be negative or zero");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} grade", base.ToString(), this.Grade);
        }
    }
}

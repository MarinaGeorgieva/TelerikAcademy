namespace _01_SchoolClasses
{
    using System;

    public class Student : Person, IComment
    {
        private int classNumber;

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;   
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Class number cannot be negative or zero");
                }

                this.classNumber = value;
            }
        }

        public string Comment { get; private set; }

        public void AddComment(string comment)
        {
            this.Comment = comment;
        }
    }
}

namespace _01_SchoolClasses
{
    using System;

    public class Discipline : IComment
    {
        private string name;
        private int lectures;
        private int exercises;

        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
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
                    throw new ArgumentException("Discipline name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int Lectures
        {
            get
            {
                return this.lectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of lectures cannot be negative");
                }

                this.lectures = value;
            }
        }

        public int Exercises
        {
            get
            {
                return this.exercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of exercises cannot be negative");
                }

                this.exercises = value;
            }
        }

        public string Comment { get; private set; }

        public void AddComment(string comment)
        {
            this.Comment = comment;
        }
    }
}

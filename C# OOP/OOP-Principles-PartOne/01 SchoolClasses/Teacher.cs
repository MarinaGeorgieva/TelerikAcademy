namespace _01_SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person, IComment
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines) : base(name)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

        public string Comment { get; private set; }

        public void AddComment(string comment)
        {
            this.Comment = comment;
        }
    }
}

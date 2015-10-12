namespace _01_SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private List<Class> classes;

        public School()
        {
            this.Classes = new List<Class>();
        }

        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
            private set
            {
                this.classes = value;
            }
        }

        public void AddClass(Class someClass)
        {
            this.Classes.Add(someClass);
        }

        public void RemoveClass(Class someClass)
        {
            this.Classes.Remove(someClass);
        }
    }
}

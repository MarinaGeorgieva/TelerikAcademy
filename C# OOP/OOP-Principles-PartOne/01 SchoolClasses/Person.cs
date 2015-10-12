namespace _01_SchoolClasses
{
    using System;

    public abstract class Person
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
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
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }        
    }
}

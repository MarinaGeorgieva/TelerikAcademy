namespace _03_AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Ribbit ribbit...");
        }
    }
}

namespace _03_AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow meow...");
        }
    }
}

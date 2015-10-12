namespace _03_AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark bark...");
        }
    }
}

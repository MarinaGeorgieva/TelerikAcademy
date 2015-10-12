// Problem 3. Animal hierarchy

// Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
// Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
// Kittens and tomcats are cats. All animals are described by age, name and sex. 
// Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.

// Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method 
// (you may use LINQ).

namespace _03_AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalHierarchyMain
    {
        static void Main(string[] args)
        {
            Dog sharo =  new Dog("Sharo", 2, Gender.Male);
            Dog mecho = new Dog("Mecho", 3, Gender.Male);
            Dog tara = new Dog("Tara", 1, Gender.Female);

            Frog froggy = new Frog("Froggy", 5, Gender.Male);
            Frog kiki = new Frog("Kiki", 2, Gender.Female);

            Cat daisy = new Cat("Daisy", 3, Gender.Female);
            Cat harry = new Cat("Harry", 4, Gender.Male);

            Kitten kitty = new Kitten("Kitty", 1);
            Tomcat tommy = new Tomcat("Tommy", 2);

            
            Animal[] animals = new Animal[]
            {
                sharo, 
                mecho, 
                tara,
                froggy,
                kiki,
                daisy,
                harry,
                kitty,
                tommy,
            };          
         

            double averageAgeOfDogs = animals.Where(animal => animal is Dog).Average(animal => animal.Age);
            double averageAgeOfFrogs = animals.Where(animal => animal is Frog).Average(animal => animal.Age);
            double averageAgeOfCats = animals.Where(animal => animal is Cat).Average(animal => animal.Age);
            double averageAgeOfKittens = animals.Where(animal => animal is Kitten).Average(animal => animal.Age);
            double averageAgeOfTomcats = animals.Where(animal => animal is Tomcat).Average(animal => animal.Age);

            Console.WriteLine("Average age of dogs: {0} \nAverage age of frogs: {1}" + 
                "\nAverage age of cats: {2} \nAverage age of kittens: {3} \nAverage age of tomcats: {4}", 
                averageAgeOfDogs, averageAgeOfFrogs, averageAgeOfCats, averageAgeOfKittens, averageAgeOfTomcats);
        }
    }
}

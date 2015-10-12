// Problem 2. Gravitation on the Moon

// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the weight on the Earth: ");
        double weightOnEarth = double.Parse(Console.ReadLine());

        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("The weight on the moon is: " + weightOnMoon);
    }
}


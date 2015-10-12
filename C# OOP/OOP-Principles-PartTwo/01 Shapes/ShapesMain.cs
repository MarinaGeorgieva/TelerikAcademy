// Problem 1. Shapes

// Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
// Define two new classes Triangle and Rectangle that implement the virtual method and return 
// the surface of the figure (height * width for rectangle and height * width/2 for triangle).
// Define class Square and suitable constructor so that at initialization height must be kept equal to width 
// and implement the CalculateSurface() method.

// Write a program that tests the behaviour of the CalculateSurface() method for different 
// shapes (Square, Rectangle, Triangle) stored in an array.

namespace _01_Shapes
{
    using System;

    public class ShapesMain
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[] 
            {
                new Rectangle(3, 4),
                new Rectangle(10, 15),
                new Rectangle(8.3, 6.7),  
              
                new Square(4.2),                
                new Square(1),
                new Square(12),

                new Triangle(2, 6),
                new Triangle(7, 4),
                new Triangle(3.5, 1.5),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Surface: {0:F2}", shape.CalculateSurface());
            }
        }
    }
}

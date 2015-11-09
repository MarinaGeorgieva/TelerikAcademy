namespace FindLargestAreaOfEmptyCells
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            char[,] matrix = new char[,]
            {
                { '-', '-', '-', 'x', '-', '-' },
                { '-', 'x', '-', 'x', '-', 'x' },
                { '-', 'x', '-', '-', 'x', '-' },
                { '-', '-', '-', '-', 'x', '-' },
                { '-', '-', 'x', 'x', '-', '-' },
                { '-', '-', '-', 'x', '-', 'x' }
            };

            Labyrinth labyrinth = new Labyrinth(matrix);
            int maxLength = labyrinth.FindLargestArea();
            Console.WriteLine("The largest area of adjacent empty cells is composed of {0} cells!", maxLength);
        }
    }
}

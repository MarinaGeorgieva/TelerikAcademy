namespace FindAllAreas
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
            var allAreas = labyrinth.FindAllAreas();
            labyrinth.Print();
            Console.WriteLine("All areas of empty cells: ");
            Console.WriteLine(string.Join(Environment.NewLine, allAreas) + Environment.NewLine);
        }
    }
}

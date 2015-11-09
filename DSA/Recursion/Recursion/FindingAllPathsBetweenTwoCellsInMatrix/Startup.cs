namespace FindingAllPathsBetweenTwoCellsInMatrix
{
    public class Startup
    {
        public static void Main()
        {
            char[,] matrix = new char[,]
            {
                { '-', '-', '-', 'x', '-', '-' },
                { '-', 'x', '-', 'x', '-', 'x' },
                { '-', 'x', '-', '-', 'x', '-' },
                { '-', 'x', '-', '-', '-', '-' },
                { '-', '-', 'x', 'x', '-', '-' },
                { '-', '-', '-', 'x', '-', 'x' }
            };

            Labyrinth labyrinth = new Labyrinth(matrix);
            labyrinth.FindPath(0, 0, 2, 5);
        }
    }
}

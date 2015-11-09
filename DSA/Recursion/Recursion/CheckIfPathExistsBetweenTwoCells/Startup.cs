namespace CheckIfPathExistsBetweenTwoCells
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            char[,] matrix = new char[100, 100];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = '-';
                }
            }

            Labyrinth labyrinth = new Labyrinth(matrix);

            if (!labyrinth.FoundPath(0, 0, 64, 97))
            {
                Console.WriteLine("A path does not exist!");
            }
        }
    }
}

namespace Labyrinth
{
    using System;

    public class Startup
    {
        private const string EmptyCell = "0";
        private const string FullCell = "x";
        private const string UnreachableCell = "u";
        private const string StartCell = "*";
        private const int StartRow = 2;
        private const int StartCol = 1;


        public static void Main()
        {
            string[,] labyrinth = new string[,]
            {
                { "0", "0", "0", "x", "0", "x"},
                { "0", "x", "0", "x", "0", "x"},
                { "0", "*", "x", "0", "x", "0"},
                { "0", "x", "0", "0", "0", "0"},
                { "0", "0", "0", "x", "x", "0"},
                { "0", "0", "0", "x", "0", "x"}
            };

            Console.WriteLine("Initial labyrinth:");
            PrintLabyrinth(labyrinth);

            TraverseLabyrinth(labyrinth, StartRow, StartCol, 0);
            FillUnreachableCells(labyrinth);
            Console.WriteLine("Labyrinth after traversal:");
            PrintLabyrinth(labyrinth);
        }

        private static void PrintLabyrinth(string[,] labyrinth)
        {
            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    Console.Write("{0,3}", labyrinth[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void TraverseLabyrinth(string[,] labyrinth, int row, int col, int step)
        {
            if (!IsInRange(row, col, labyrinth))
            {
                return;
            }

            if (labyrinth[row, col] == FullCell)
            {
                return;
            }

            if (labyrinth[row, col] != StartCell && labyrinth[row, col] != EmptyCell && step > int.Parse(labyrinth[row, col]))
            {
                return;
            }

            if (labyrinth[row, col] != StartCell)
            {
                labyrinth[row, col] = step.ToString();
            }
            
            TraverseLabyrinth(labyrinth, row - 1, col, step + 1);
            TraverseLabyrinth(labyrinth, row + 1, col, step + 1);
            TraverseLabyrinth(labyrinth, row, col - 1, step + 1);
            TraverseLabyrinth(labyrinth, row, col + 1, step + 1);
        }

        private static void FillUnreachableCells(string[,] labyrinth)
        {
            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    if (labyrinth[row, col] == EmptyCell)
                    {
                        labyrinth[row, col] = UnreachableCell;
                    }
                }
            }
        }

        private static bool IsInRange(int row, int col, string[,] labyrinth)
        {
            bool isRowInRange = row >= 0 && row < labyrinth.GetLength(0);
            bool isColInRange = col >= 0 && col < labyrinth.GetLength(1);
            bool isInRange = isRowInRange && isColInRange;
            return isInRange;
        }
    }
}

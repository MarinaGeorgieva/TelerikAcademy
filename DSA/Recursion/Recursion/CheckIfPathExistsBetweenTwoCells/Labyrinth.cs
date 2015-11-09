namespace CheckIfPathExistsBetweenTwoCells
{
    using System;

    public class Labyrinth
    {
        private const char FullCell = 'x';
        private const char EmptyCell = '-';
        private const char PassedCell = 'o';

        private static readonly int[] RowsDiff = new int[] { -1, 0, 1, 0 };
        private static readonly int[] ColsDiff = new int[] { 0, 1, 0, -1 };

        private char[,] matrix;

        public Labyrinth(char[,] matrix)
        {
            this.matrix = matrix;
        }

        public bool FoundPath(int startRow, int startCol, int endRow, int endCol)
        {
            if (!this.IsValidMove(startRow, startCol))
            {
                return false;
            }

            if (this.matrix[startRow, startCol] == FullCell ||
                this.matrix[startRow, startCol] == PassedCell)
            {
                return false;
            }

            if (this.EndCellReached(startRow, startCol, endRow, endCol))
            {
                Console.WriteLine("Found path!");
                return true;
            }

            this.MarkCell(startRow, startCol);

            for (int i = 0; i < RowsDiff.Length; i++)
            {
                if (this.FoundPath(startRow + RowsDiff[i], startCol + ColsDiff[i], endRow, endCol))
                {
                    return true;
                }
            }

            this.UnmarkCell(startRow, startCol);

            return false;
        }

        private void UnmarkCell(int row, int col)
        {
            this.matrix[row, col] = EmptyCell;
        }

        private void MarkCell(int row, int col)
        {
            this.matrix[row, col] = PassedCell;
        }

        private bool EndCellReached(int startRow, int startCol, int endRow, int endCol)
        {
            return startRow == endRow && startCol == endCol;
        }

        private bool IsValidMove(int row, int col)
        {
            bool isValidRow = row >= 0 && row < this.matrix.GetLength(0);
            bool isValidCol = col >= 0 && col < this.matrix.GetLength(1);

            return isValidRow && isValidCol;
        }
    }
}

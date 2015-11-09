namespace FindingAllPathsBetweenTwoCellsInMatrix
{
    using System;

    public class Labyrinth
    {
        private const char FullCell = 'x';
        private const char EmptyCell = '-';
        private const char PassedCell = 'o';
        private const char ExitCell = 'e';

        private static readonly int[] RowsDiff = new int[] { -1, 0, 1, 0 };
        private static readonly int[] ColsDiff = new int[] { 0, 1, 0, -1 };

        private char[,] matrix;

        public Labyrinth(char[,] matrix)
        {
            this.matrix = matrix;
        }

        public void FindPath(int startRow, int startCol, int endRow, int endCol)
        {
            if (!this.IsValidMove(startRow, startCol))
            {
                return;
            }

            if (this.matrix[startRow, startCol] == FullCell || 
                this.matrix[startRow, startCol] == PassedCell)
            {
                return;
            }

            if (this.EndCellReached(startRow, startCol, endRow, endCol))
            {
                this.matrix[endRow, endCol] = ExitCell;
                this.PrintPath();
                this.UnmarkCell(endRow, endCol);
                return;
            }

            this.MarkCell(startRow, startCol);

            for (int i = 0; i < RowsDiff.Length; i++)
            {
                this.FindPath(startRow + owsDiff[i], startCol + ColsDiff[i], endRow, endCol);
            }

            this.UnmarkCell(startRow, startCol);
        }

        private void UnmarkCell(int row, int col)
        {
            this.matrix[row, col] = EmptyCell;
        }

        private void MarkCell(int row, int col)
        {
            this.matrix[row, col] = PassedCell;           
        }

        private void PrintPath()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 2}", this.matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
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

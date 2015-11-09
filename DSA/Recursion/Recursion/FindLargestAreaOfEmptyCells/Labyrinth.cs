namespace FindLargestAreaOfEmptyCells
{
    public class Labyrinth
    {
        private const char FullCell = 'x';
        private const char EmptyCell = '-';
        private const char PassedCell = 'o';

        private static readonly int[] RowsDiff = new int[] { -1, 0, 1, 0 };
        private static readonly int[] ColsDiff = new int[] { 0, 1, 0, -1 };

        private static int length = 0;
        private static int maxLength = 0;

        private char[,] matrix;

        public Labyrinth(char[,] matrix)
        {
            this.matrix = matrix;
        }

        public int FindLargestArea()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    length = 0;

                    this.FindArea(row, col);

                    if (length >= maxLength)
                    {
                        maxLength = length;
                    }
                }
            }

            return maxLength;
        }

        private void FindArea(int row, int col)
        {
            if (!this.IsValidMove(row, col))
            {
                return;
            }

            if (this.matrix[row, col] == FullCell || this.matrix[row, col] == PassedCell)
            {
                return;
            }

            this.MarkCell(row, col);
            length++;

            for (int i = 0; i < RowsDiff.Length; i++)
            {
                this.FindArea(row + RowsDiff[i], col + ColsDiff[i]);
            }
        }

        private void MarkCell(int row, int col)
        {
            this.matrix[row, col] = PassedCell;
        }

        private bool IsValidMove(int row, int col)
        {
            bool isValidRow = row >= 0 && row < this.matrix.GetLength(0);
            bool isValidCol = col >= 0 && col < this.matrix.GetLength(1);

            return isValidRow && isValidCol;
        }
    }
}

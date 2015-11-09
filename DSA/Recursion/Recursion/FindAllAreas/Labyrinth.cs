namespace FindAllAreas
{
    using System;
    using System.Collections.Generic;

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

        public void Print()
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

        public IList<string> FindAllAreas()
        {
            var allAreas = new List<string>();
            var currentArea = new List<string>();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    currentArea.Clear();

                    this.FindArea(row, col, currentArea);

                    if (currentArea.Count > 0)
                    {
                        allAreas.Add(string.Format("{0} -> Length: {1}", string.Join(" -> ", currentArea), currentArea.Count));
                    }
                }
            }

            return allAreas;
        }

        private void FindArea(int row, int col, IList<string> area)
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
            area.Add(string.Format("({0},{1})", row, col));

            for (int i = 0; i < RowsDiff.Length; i++)
            {
                this.FindArea(row + RowsDiff[i], col + ColsDiff[i], area);
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

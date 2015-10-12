namespace LoverOfTwo
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class LoverOfTwo
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int numberOfDirectionsAndMoves = int.Parse(Console.ReadLine());
            int coeff = Math.Max(rows, cols);

            int[] codes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            BigInteger[,] field = new BigInteger[rows, cols];
            field = FillField(field);

            int pawnCurrentRow = rows - 1;
            int pawnCurrentCol = 0;
            BigInteger totalScore = 0;

            for (int i = 0; i < numberOfDirectionsAndMoves; i++)
            {
                int pawnEndRow = codes[i] / coeff;
                int pawnEndCol = codes[i] % coeff;
                int pawnStartRow = pawnCurrentRow;
                int pawnStartCol = pawnCurrentCol;

                totalScore = MoveVertically(pawnStartRow, pawnEndRow, ref totalScore, field, ref pawnCurrentRow, pawnCurrentCol);
                totalScore = MoveHorizontally(pawnStartCol, pawnEndCol, ref totalScore, field, pawnCurrentRow, ref pawnCurrentCol);
            }

            Console.WriteLine(totalScore);
        }

        private static BigInteger MoveVertically(int start, int end, ref BigInteger score, BigInteger[,] field, ref int currentRow, int currentCol)
        {
            for (int i = 0; i < Math.Abs(end - start); i++)
            {
                score += field[currentRow, currentCol];
                field[currentRow, currentCol] = 0;

                if (currentRow > end)
                {
                    currentRow--;
                }
                else if (currentRow < end)
                {
                    currentRow++;
                }

                score += field[currentRow, currentCol];
                field[currentRow, currentCol] = 0;
            }

            return score;
        }

        private static BigInteger MoveHorizontally(int start, int end, ref BigInteger score, BigInteger[,] field, int currentRow, ref int currentCol)
        {
            for (int i = 0; i < Math.Abs(end - start); i++)
            {
                score += field[currentRow, currentCol];
                field[currentRow, currentCol] = 0;

                if (currentCol > end)
                {
                    currentCol--;
                }
                else if (currentCol < end)
                {
                    currentCol++;
                }

                score += field[currentRow, currentCol];
                field[currentRow, currentCol] = 0;
            }

            return score;
        }

        private static BigInteger[,] FillField(BigInteger[,] field)
        {
            for (int row = field.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = Power(2, field.GetLength(0) - 1 - row + col);
                }
            }

            return field;
        }

        private static BigInteger Power(int number, int power)
        {
            BigInteger result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}

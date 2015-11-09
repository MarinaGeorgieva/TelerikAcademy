namespace EightQueensPuzzle
{
    using System;
    using System.Collections.Generic;

    public class QueenPuzzleSolver
    {
        private const char EmptyCell = '+';
        private const char Queen = 'Q';

        private char[,] board;
        private int size;

        private HashSet<int> attackedRows = new HashSet<int>();
        private HashSet<int> attackedCols = new HashSet<int>();
        private HashSet<int> attackedRightDiagonals = new HashSet<int>();
        private HashSet<int> attackedLeftDiagonals = new HashSet<int>();

        public QueenPuzzleSolver(int size)
        {
            this.size = size;
            this.board = new char[size, size];
            this.FillBoard();
        }

        public void PutQueens(int row)
        {
            if (row == this.size)
            {
                this.PrintBoard();
                return;
            }

            for (int col = 0; col < this.size; col++)
            {
                if (this.CanPlaceQueen(row, col))
                {
                    this.MarkAllAttackedPositons(row, col);
                    this.PutQueens(row + 1);
                    this.UnMarkAllAttackedPositons(row, col);
                }
            }
        }

        private void UnMarkAllAttackedPositons(int row, int col)
        {
            this.attackedRows.Remove(row);
            this.attackedCols.Remove(col);
            this.attackedRightDiagonals.Remove(col + row);
            this.attackedLeftDiagonals.Remove(col - row);
            this.RemoveQueen(row, col);
        }

        private void MarkAllAttackedPositons(int row, int col)
        {
            this.attackedRows.Add(row);
            this.attackedCols.Add(col);
            this.attackedRightDiagonals.Add(col + row);
            this.attackedLeftDiagonals.Add(col - row);
            this.PlaceQueen(row, col);
        }

        private void PlaceQueen(int row, int col)
        {
            this.board[row, col] = Queen;
        }

        private void RemoveQueen(int row, int col)
        {
            this.board[row, col] = EmptyCell;
        }

        private bool CanPlaceQueen(int row, int col)
        {
            bool canPlaceQueen = true;

            if (this.attackedRows.Contains(row) ||
                this.attackedCols.Contains(col) ||
                this.attackedRightDiagonals.Contains(col + row) ||
                this.attackedLeftDiagonals.Contains(col - row))
            {
                canPlaceQueen = false;
            }

            return canPlaceQueen;
        }

        private void PrintBoard()
        {
            for (int row = 0; row < this.board.GetLength(0); row++)
            {
                for (int col = 0; col < this.board.GetLength(1); col++)
                {
                    Console.Write("{0, 2}", this.board[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private void FillBoard()
        {
            for (int row = 0; row < this.board.GetLength(0); row++)
            {
                for (int col = 0; col < this.board.GetLength(1); col++)
                {
                    this.board[row, col] = EmptyCell;
                }
            }
        }
    }
}

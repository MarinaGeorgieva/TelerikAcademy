/* Problem 8. Matrix

Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
 
Problem 9. Matrix indexer

Implement an indexer this[row, col] to access the inner matrix cells.
 
Problem 10. Matrix operations

Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
Throw an exception when the operation cannot be performed.
Implement the true operator (check for non-zero elements). */



namespace DifiningClassesProblem8_10
{
    using System;
    using System.Text;

    public class Matrix<T> where T : struct, IComparable
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public int Rows
        {
            get 
            { 
                return this.rows; 
            }
            set
            {
                if (value > 0)
                {
                    this.rows = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Rows must be positive number");
                }
            }
        }

        public int Cols
        {
            get 
            { 
                return this.cols; 
            }
            set
            {
                if (value > 0)
                {
                    this.cols = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Cols must be positive number");
                }
            }
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[this.rows, this.cols];
        } 

        public Matrix(T[,] predefinedMatrix) 
        {
            this.matrix = predefinedMatrix;
            this.rows = matrix.GetLength(0);
            this.cols = matrix.GetLength(1);
        }

        public T this[int indexOfRows, int indexOfCols]
        {
            get
            {
                if (indexOfRows > this.rows - 1 || indexOfRows < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (indexOfCols > this.cols - 1 || indexOfCols < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                
                return this.matrix[indexOfRows, indexOfCols];                
            }

            set 
            { 
                this.matrix[indexOfRows, indexOfCols] = value; 
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and columns");
            }

            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)first[i, j] + second[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and columns");
            }

            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)first[i, j] - second[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols != second.Rows)
            {
                throw new ArgumentException("Cannot be multiplied");
            }

            Matrix<T> resultMatrix = new Matrix<T>(first.Rows, second.Cols);
            T result = (dynamic)0;

            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < second.Cols; j++)
                {
                    for (int k = 0; k < first.Cols; k++)
                    {
                        result += (dynamic)first[i, k] * second[k, j];
                    }
                    resultMatrix[i, j] = result;
                    result = (dynamic)0;
                }
            }
            return resultMatrix;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    result.Append(string.Format("{0, 11}", this.matrix[i, j]));
                }
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }

        public static bool operator true(Matrix<T> matrix)
        {

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}


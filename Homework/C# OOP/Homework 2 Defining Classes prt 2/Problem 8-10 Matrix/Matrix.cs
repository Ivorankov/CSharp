
namespace Problem_8_10_Matrix
{
    using System;
    using System.Text;
    class Matrix<T> where T : struct, IComparable, IComparable<T>, IEquatable<T>
    {
        //Problem 8
        private int row;
        private int col;
        private T[,] matrix;

        public int Row
        {
            get { return this.row; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Matrix cannot contain less then 1 rows!");
                }
                this.row = value; 
            }
        }
        public int Col
        {
            get { return this.col; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Matrix cannot contain less then 1 cols!");
                }
                this.col = value; 
            }
        }
        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[row, col];
        }
        //Problem 9
        public T this[int row, int col]
        {
            get 
            {
                if (row < 0 || row > this.Row || col < 0 || col > this.Col)
                {
                    throw new ArgumentOutOfRangeException("Index was outside of the boudaries of the matrix");
                }
                return matrix[row, col];
            }
            set
            {
                if (row < 0 || row > this.Row || col < 0 || col > this.Col)
                {
                    throw new ArgumentOutOfRangeException("Index was outside of the boudaries of the matrix");
                }
                this.matrix[row,col] = value;
            }
        }
        //Problem 10
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row != second.Row || first.Col != second.Col)
            {
                throw new ArgumentException("The matrixes are not of an equal size");
            }
            var newMatrix = new Matrix<T>(first.Row,first.Col);
            for (int row = 0; row < first.Row; row++)
            {
                for (int col = 0; col < first.Col; col++)
                {
                    newMatrix[row, col] = (dynamic)first[row, col] + second[row, col];
                }
            }
            return newMatrix;
        }
        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row != second.Row || first.Col != second.Col)
            {
                throw new ArgumentException("The matrixes are not of an equal size");
            }
            var newMatrix = new Matrix<T>(first.Row, first.Col);
            for (int row = 0; row < first.Row; row++)
            {
                for (int col = 0; col < first.Col; col++)
                {
                    newMatrix[row, col] = (dynamic)first[row, col] - second[row, col];
                }
            }
            return newMatrix;
        }
        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Col != second.Row)
            {
                throw new ArgumentException("The matrixes are not of an equal size");
            }
            var newMatrix = new Matrix<T>(first.Row, second.Col);
            var multipValue = (dynamic)0;
            for (int row = 0; row < first.Row; row++)
            {
                for (int col = 0; col < first.Col; col++)
                {
                    for (int i = 0; i < second.Col; i++)
                    {
                        multipValue += (dynamic)first[row, col] * second[row, col];
                    }
                    newMatrix[row, col] = multipValue;
                    multipValue = (dynamic)0;
                }
            }
            return newMatrix;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            bool isZero = false;
            for (int row = 0; row < matrix.Row; row++)
            {
                for (int col = 0; col < matrix.Col; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        isZero = true;
                        return isZero;
                    }
                }
            }
            return isZero;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            bool isZero = false;
            for (int row = 0; row < matrix.Row; row++)
            {
                for (int col = 0; col < matrix.Col; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        isZero = true;
                        return isZero;
                    }
                }
            }
            return isZero;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < this.Row; row++)
            {
                for (int col = 0; col < this.Col; col++)
                {
                    result.Append(this.matrix[row, col] + " ");
                }
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}

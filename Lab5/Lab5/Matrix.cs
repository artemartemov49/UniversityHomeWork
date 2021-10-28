using System;

namespace Task3
{
    public class Matrix
    {
        private protected int Rows { get; }
        private protected int Columns { get; }
        private protected double[,] MatrixArray;

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            MatrixArray = GetMatrix();
        }

        protected virtual double[,] GetMatrix()
        {
            var m = new double[Rows, Columns];
            for (var rowIndex = 0; rowIndex < Rows; rowIndex++)
            {
                for (var columnIndex = 0; columnIndex < Columns; columnIndex++)
                {
                    m[rowIndex, columnIndex] = 1;
                }
            }

            return m;
        }

        public void PrintMatrix()
        {
            var rowLength = MatrixArray.GetLength(0);
            var colLength = MatrixArray.GetLength(1);

            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    Console.Write("{0} ", MatrixArray[i, j]);
                }

                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
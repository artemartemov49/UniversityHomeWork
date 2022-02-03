namespace Task3
{
    public class LowerTriangularMatrix : Matrix
    {
        public LowerTriangularMatrix(int rows, int columns) : base(rows, columns)
        {
            MatrixArray = GetMatrix();
        }

        protected sealed override double[,] GetMatrix()
        {
            var m = new double[Rows, Columns];
            var counter = 0;

            for (var rowIndex = 0; rowIndex < Rows; rowIndex++)
            {
                for (var columnIndex = counter; columnIndex < Columns; columnIndex++)
                {
                    m[rowIndex, columnIndex] = 1;
                }

                counter++;
            }

            return m;
        }
    }
}
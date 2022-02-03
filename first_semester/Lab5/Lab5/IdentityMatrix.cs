namespace Task3
{
    public class IdentityMatrix : Matrix
    {
        public IdentityMatrix(int rows, int columns) : base(rows, columns)
        {
            MatrixArray = GetMatrix();
        }

        protected sealed override double[,] GetMatrix()
        {
            var m = new double[Rows, Columns];
            var counter = 0;

            for (var rowIndex = 0; rowIndex < Rows; rowIndex++)
            {
                for (var columnIndex = 0; columnIndex < Columns; columnIndex++)
                {
                    if (counter == columnIndex)
                    {
                        m[rowIndex, columnIndex] = 1;
                        counter++;
                        break;
                    }
                }
            }

            return m;
        }
    }
}
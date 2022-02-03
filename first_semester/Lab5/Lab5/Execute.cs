using System;

namespace Task3
{
    internal class Execute
    {
        static void Main(string[] args)
        {
            var identityMatrix = new IdentityMatrix(3, 3);
            var lowerTriangularMatrix = new LowerTriangularMatrix(3, 3);
            identityMatrix.PrintMatrix();
            Console.WriteLine(Environment.NewLine);
            lowerTriangularMatrix.PrintMatrix();
            Console.ReadLine();
        }
    }
}

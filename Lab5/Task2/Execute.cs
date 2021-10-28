using System;
using static ParserUtils.ParserUtil;

namespace Task2
{
    internal class Execute
    {
        static void Main(string[] args)
        {
            var height = ValidateAndParseDoublePositive("height");
            var baseRadius = ValidateAndParseDoublePositive("base radius");
            var r1 = ValidateAndParseDoublePositive("r1");

            var coneBase = new ConeBase(baseRadius, height);
            coneBase.PrintInfo();

            var truncatedCone = new TruncatedCone(baseRadius, height, r1);
            truncatedCone.PrintInfo();
        }
    }
}
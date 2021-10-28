using System;
using static ParserUtils.ParserUtil;

namespace Task1
{
    internal class Execute
    {
        static void Main(string[] args)
        {
            var x = ValidateAndParseInt("x coordinate");
            var y = ValidateAndParseInt("y coordinate");
            var sidesSize = ValidateAndParseIntPositive("sides size");

            var rectangleTMovement = new RectangleMovement(x, y, sidesSize);
            rectangleTMovement.Move();
            Console.Clear();
            var rectangleTurning = new RectangleTurning(x, y, sidesSize);
            rectangleTurning.Move();
        }
    }
}
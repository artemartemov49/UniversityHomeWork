using System;
using static ParserUtils.ParserUtil;

namespace RectangleTask
{
    class Rectangle
    {
        private readonly double _side1;
        private readonly double _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double AreaCalculator()
        {
            return _side1 * _side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (_side1 + _side2);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Area: " + AreaCalculator());
            Console.WriteLine("Perimeter: " + PerimeterCalculator());
        }

        public static Rectangle CreateRectangle()
        {
            var x = ValidateAndParseDouble("Side 1");
            var y = ValidateAndParseDouble("Side 2");
            return new Rectangle(x, y);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace FigureAndPintTask
{
    class Figure
    {
        private readonly List<Point> _points = new();

        public Figure(Point p1, Point p2, Point p3)
        {
            _points.Add(p1);
            _points.Add(p2);
            _points.Add(p3);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3)
        {
            _points.Add(p4);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(p1, p2, p3, p4)
        {
            _points.Add(p5);
        }

        public Figure(List<Point> points)
        {
            _points = points;
        }

        public static double LengthSide(Point a, Point b)
        {
            var x = Math.Abs(a.X - b.X);
            var y = Math.Abs(a.Y - b.Y);
            var toSqrt = (Math.Pow(x, 2) + Math.Pow(y, 2));
            return Math.Sqrt(toSqrt);
        }

        public void PerimeterCalculator()
        {
            double result = 0;
            var counter = 0;
            while (counter < _points.Count - 1)
            {
                var a = _points[counter];
                var b = _points[counter + 1];
                result += LengthSide(a, b);
                counter++;
            }

            result += LengthSide(_points[0], _points[^1]);
            Console.WriteLine($"Perimeter: {result}");
        }
    }
}

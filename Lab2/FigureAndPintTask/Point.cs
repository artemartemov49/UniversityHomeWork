using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParserUtils.ParserUtil;

namespace FigureAndPintTask
{
    class Point
    {
        private readonly int x;
        private readonly int y;
        private readonly string pointName;

        public int X => x;

        public int Y => y;
        public string PointName => pointName;

        public Point(int x, int y, string pointName)
        {
            this.x = x;
            this.y = y;
            this.pointName = pointName;
        }


        public static List<Point> CreatePoints()
        {
            var result = new List<Point>();
            Console.WriteLine("Hello! Choose count of points from 3 to 5");
            var countOfPoints = ValidateAndParseIntRange("count of points", 2, 6);
            for (var i = 0; i < countOfPoints; i++)
            {
                result.Add(CreatePoint());
            }
            return result;
        }

        private static Point CreatePoint()
        {
            Console.WriteLine("Enter 2 int values and point name");
            var x = ValidateAndParseInt("first value");
            var y = ValidateAndParseInt("second value");
            var name = ValidateAndParseStringIsLetter("point name");
            return new Point(x, y, name);
        }
    }
}
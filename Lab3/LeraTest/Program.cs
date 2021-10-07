using System;

namespace LeraTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure cube = new Figure("cube");
            Console.WriteLine(cube.PerimeterCalculator());
            Console.ReadKey();

        }
    }
    class Point
    {
        string name;
        int a, b;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int A
        {
            get
            {
                return a;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int a, int b)
        {
            Console.WriteLine("Введiть назву многокутника: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Введiть значення 1:");
            this.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть значення 2:");
            this.b = int.Parse(Console.ReadLine());
        }
    }
    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitFigure()
        {
            Console.WriteLine("Введіть кількість сторін:");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }
        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(a.A - b.A), 2) + Math.Pow(Math.Abs(a.B - b.B), 2));
        }
        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                Console.WriteLine(points[i - 1].A +" "+ points[i - 1].B);
                perimeter += LengthSide(points[i - 1], points[i]);
            }
            perimeter += LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitFigure();
        }
    }
}

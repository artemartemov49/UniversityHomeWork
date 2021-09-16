namespace FigureAndPintTask
{
    class ExecuteFigure
    {
        static void Main(string[] args)
        {
            var points = Point.CreatePoints();
            var figure = new Figure(points);
            figure.PerimeterCalculator();
        }
    }
}

using System;

namespace Task2
{
    public class ConeBase
    {
        private protected readonly double BaseRadius;
        private protected readonly double H;

        public ConeBase(double baseRadius, double h)
        {
            BaseRadius = baseRadius;
            H = h;
        }


        public virtual double CalculateVolume()
        {
            var area = CalculateArea();
            return (double) 1 / 3 * H * area;
        }

        private double CalculateArea()
        {
            return Math.Pow(BaseRadius, 2) * Math.PI;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("ConeBase");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Parameters: height - {H}, base radius - {BaseRadius}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Volume: {CalculateVolume()}");
            Console.WriteLine();
        }
    }
}
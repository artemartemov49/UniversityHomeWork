using System;

namespace Task2
{
    public class TruncatedCone : ConeBase
    {
        private protected readonly double R1;

        public TruncatedCone(double baseRadius, double h, double r1) : base(baseRadius, h)
        {
            R1 = r1;
        }

        public override double CalculateVolume()
        {
            return (double) 1 / 3 * Math.PI * H * (Math.Pow(BaseRadius, 2) + Math.Pow(R1, 2) + (BaseRadius * R1));
        }

        public override void PrintInfo()
        {
            Console.WriteLine("TruncatedCone");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Parameters: height - {H}, base radius - {BaseRadius}, R1 - {R1}");
            Console.WriteLine($"Volume: {CalculateVolume()}");
        }
    }
}
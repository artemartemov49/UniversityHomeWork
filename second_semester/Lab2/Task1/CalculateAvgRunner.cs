namespace Task1
{
    internal class CalculateAvgRunner
    {
        static void Main(string[] args)
        {
            Func<int, int, int, double> GetAvg = (v1, v2, v3) => new List<int> {v1, v2, v3}.Average();
            Console.WriteLine(GetAvg(1, 2, 3));
        }
    }
}
namespace Task1
{
    internal class CalculateAvgRunner
    {
        static void Main(string[] args)
        {
            double GetAverage(int v1, int v2, int v3) => new List<int> {v1, v2, v3}.Average();
            Console.WriteLine(GetAverage(1, 2, 3));
        }
    }
}
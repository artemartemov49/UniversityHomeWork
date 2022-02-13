using System.Linq;

namespace Task2
{
    public delegate int GetRandomValueDelegate();

    internal class DelegateArrayRunner
    {
        private static int GetRandomValue() => new Random().Next(10);

        private static readonly GetRandomValueDelegate[] RandomValueList =
        {
            GetRandomValue,
            GetRandomValue,
            GetRandomValue,
            GetRandomValue,
            GetRandomValue,
            GetRandomValue,
        };

        static void Main(string[] args)
        {
            double GetArrayAvg(GetRandomValueDelegate[] values)
            {
                var list = values
                    .Select(randomValue => randomValue.Invoke())
                    .ToList();

                Console.WriteLine("[{0}]", string.Join(", ", list));
                return list.Average();
            }


            Console.WriteLine(GetArrayAvg(RandomValueList));
        }
    }
}
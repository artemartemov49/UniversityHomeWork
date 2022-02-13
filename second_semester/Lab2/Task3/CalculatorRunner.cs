namespace Task3
{
    internal class CalculatorRunner
    {
        static void Main(string[] args)
        {
            var s = "2+2*2";
            Parser.EvaluatePriorityOperations(ref s);
        }
    }
}
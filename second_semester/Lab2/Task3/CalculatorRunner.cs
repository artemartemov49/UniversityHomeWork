using System.Text.RegularExpressions;

namespace Task3
{
    internal class CalculatorRunner
    {
        private static readonly Regex Formula = new(@"^\s*((\d+)([.]\d+)?(?:\s*([-+*\/])\s*(\d+)([.]\d+)?\s*)+)[=]?\s*$");
        static void Main(string[] args)
        {
            const string input = "2+2*2/0 =";
            ValidateStringToCalculate(input);
            var value = RemoveUnnecessarySymbols(input);
            Calculator.Calculate(value);
        }

        private static void ValidateStringToCalculate(string value)
        {
            if (!Formula.IsMatch(value))
            {
                throw new ArithmeticException("Oops! Sorry, this string cannot be calculated");
            }
        }

        private static string RemoveUnnecessarySymbols(string value)
        {
            return new string(value.ToCharArray()
                    .Where(c => !char.IsWhiteSpace(c) && !c.Equals('='))
                    .ToArray())
                .Replace(",", ".");
        }
    }
}
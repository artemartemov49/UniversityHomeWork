using System;
using static Lab3.Validator;

namespace Lab3
{
    internal class InputManager
    {
        public static FormulaEntity GetFormula()
        {
            Console.WriteLine("Hello! Enter numbers to calculate: ");
            while (true)
            {
                var line = Parser.ParseLine();
                if (IsMatch(line))
                {
                    return BuildEntity(line);
                }

                Console.WriteLine("Oops.. You entered inappropriate value");
            }
        }

        private static FormulaEntity BuildEntity(string formula)
        {
            var firstNumber = decimal.Parse(GetRegexGroupValue(formula, 1));
            var symbol = char.Parse(GetRegexGroupValue(formula, 2));
            var secondNumber = decimal.Parse(GetRegexGroupValue(formula, 3));
            return new FormulaEntity(firstNumber, symbol, secondNumber);
        }

        private static string GetRegexGroupValue(string formula, int index)
        {
            return Formula.Match(formula).Groups[index].Value;
        }
    }
}
using System;
using System.Linq;
using System.Text.RegularExpressions;
using static Lab3.Validator;

namespace Lab3
{
    internal class InputManager
    {
        public static FormulaEntity GetFormula()
        {
            Console.WriteLine("Hello enter numbers to calculate: ");
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
            var firstNumber = decimal.Parse(RegexGroupValue(formula, 1));
            var charSpliterator = char.Parse(RegexGroupValue(formula, 2));
            var secondNumber = decimal.Parse(RegexGroupValue(formula, 3));
            return new FormulaEntity(firstNumber, charSpliterator, secondNumber);
        }

        private static string RegexGroupValue(string formula, int index)
        {
            return Formula.Match(formula).Groups[index].Value;
        }
    }
}
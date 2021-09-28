using System;

namespace Lab3
{
    public static class Calculator
    {
        public static void Calculate(FormulaEntity formula)
        {
            var v1 = formula.FirstNumber;
            var v2 = formula.SecondNumber;

            switch (formula.Char)
            {
                case '+':
                    AddValue(v1, v2);
                    break;
                case '-':
                    Subtract(v1, v2);
                    break;
                case '/':
                    Divide(v1, v2);
                    break;
                case '*':
                    Multiply(v1, v2);
                    break;
            }
        }

        private static void AddValue(decimal v1, decimal v2)
        {
            var res = decimal.Add(v1, v2);
            Console.WriteLine($"{res}");
        }

        private static void Subtract(decimal v1, decimal v2)
        {
            var res = decimal.Subtract(v1, v2);
            Console.WriteLine($"{res}");
        }

        private static void Divide(decimal v1, decimal v2)
        {
            var res = decimal.Divide(v1, v2);
            Console.WriteLine($"{res}");
        }

        private static void Multiply(decimal v1, decimal v2)
        {
            var res = decimal.Multiply(v1, v2);
            Console.WriteLine($"{res}");
        }
    }
}
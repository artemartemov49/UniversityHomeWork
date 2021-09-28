using System;

namespace Lab3
{
    internal class CalculatorExecute
    {
        static void Main(string[] args)
        {
            var formula = InputManager.GetFormula();
            Calculator.Calculate(formula);
        }
    }
}

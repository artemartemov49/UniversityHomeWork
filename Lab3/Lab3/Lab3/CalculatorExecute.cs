using System;

namespace Lab3
{
    internal class CalculatorExecute
    {
        static void Main(string[] args)
        {
            var formulaEntity = InputManager.GetFormula();
            Calculator.Calculate(formulaEntity);
        }
    }
}

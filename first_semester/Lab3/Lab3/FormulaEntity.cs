namespace Lab3
{
    public class FormulaEntity
    {
        public decimal FirstNumber { get; }
        public char Char { get; }
        public decimal SecondNumber { get; }

        public FormulaEntity(decimal firstNumber, char c, decimal secondNumber)
        {
            FirstNumber = firstNumber;
            Char = c;
            SecondNumber = secondNumber;
        }
    }
}

namespace Task3;

public class Calculator
{
    public static decimal Calculate(decimal firstNumber, decimal secondNumber, char operationChar)
    {
        return operationChar switch
        {
            '+' => AddValue(firstNumber, secondNumber),
            '-' => Subtract(firstNumber, secondNumber),
            '/' => Divide(firstNumber, secondNumber),
            '*' => Multiply(firstNumber, secondNumber),
            _ => 0
        };
    }

    private static decimal AddValue(decimal v1, decimal v2) => decimal.Add(v1, v2);

    private static decimal Subtract(decimal v1, decimal v2) => decimal.Subtract(v1, v2);

    private static decimal Divide(decimal v1, decimal v2) => decimal.Divide(v1, v2);
    private static decimal Multiply(decimal v1, decimal v2) => decimal.Multiply(v1, v2);
}
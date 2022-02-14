using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Task3;

public class Calculator : BasicCalculator
{
    private static readonly char[] PriorityOperations =
    {
        '/', '*'
    };

    private static readonly char[] OrdinalOperations =
    {
        '+', '-'
    };

    private static readonly char[] AllOperations =
    {
        '+', '-', '*', '/'
    };

    public static decimal Calculate(string value)
    {
        EvaluateOperations(ref value, PriorityOperations);
        EvaluateOperations(ref value, OrdinalOperations);


        Console.WriteLine($"Your result is: {value}");
        return decimal.Parse(value);
    }

    private static void EvaluateOperations(ref string value, char[] operations)
    {
        var charIndex = value.IndexOfAny(operations);


        while (charIndex != -1)
        {
            var indexOfRightLastNumber = value.IndexOfAny(AllOperations, charIndex + 1);
            var indexOfLeftFirstNumber = value[..(charIndex - 1)].LastIndexOfAny(AllOperations);

            indexOfRightLastNumber = indexOfRightLastNumber == -1
                ? value.Length
                : indexOfRightLastNumber;


            var firstNumber = value.Substring(indexOfLeftFirstNumber + 1, charIndex - indexOfLeftFirstNumber - 1);
            var secondNumber = value.Substring(charIndex + 1, indexOfRightLastNumber - charIndex - 1);
            var operationChar = value[charIndex];

            var evaluationResult =
                BasicCalculator.CalculateFormula(decimal.Parse(firstNumber), decimal.Parse(secondNumber), operationChar);

            value = value.Replace(
                value.Substring(indexOfLeftFirstNumber + 1, indexOfRightLastNumber - indexOfLeftFirstNumber - 1),
                evaluationResult.ToString(CultureInfo.CurrentCulture));

            charIndex = value.IndexOfAny(operations, 1);
        }
    }
}
namespace Task3;

public class ArithmeticEntity
{
    public double FirstValue { get; set; }
    public double SecondValue { get; set; }
    public Func<double, double, double> Action;

    public ArithmeticEntity(double firstValue, double secondValue, Func<double, double, double> action)
    {
        FirstValue = firstValue;
        SecondValue = secondValue;
        Action = action;
    }
}
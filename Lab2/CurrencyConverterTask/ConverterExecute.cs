namespace CurrencyConverterTask
{
    class ConverterExecute
    {
        static void Main(string[] args)
        {
            var currencyConverter = Converter.CreateCurrencyConverter();
            currencyConverter.PrintInfo();
        }
    }
}
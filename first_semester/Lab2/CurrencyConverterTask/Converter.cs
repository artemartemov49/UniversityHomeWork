using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using static CurrencyConverterTask.Currency;
using static ParserUtils.ParserUtil;

namespace CurrencyConverterTask
{
    class Converter
    {
        private IDictionary<Currency, double> ConversionRate { get; }

        private Converter(IDictionary<Currency, double> conversionRate)
        {
            ConversionRate = conversionRate;
        }

        public static Converter CreateCurrencyConverter()
        {
            var currency = GetCurrency();
            var amountOfMoney = ValidateAndParseDoubleRange("count of currencyType", 0, int.MaxValue);
            var conversionRate = GetConversionRate(currency, amountOfMoney);
            return new Converter(conversionRate);
        }

        private static Currency GetCurrency()
        {
            var currencyList = new List<string>()
            {
                EUR.ToString(),
                RUB.ToString(),
                UAH.ToString(),
                USD.ToString()
            };
            return Enum.Parse<Currency>(ValidateAndParseExactWordList("currencyType to convert", currencyList));
        }

        private static IDictionary<Currency, double> GetConversionRate(Currency currencyType, double amountOfMoney)
        {
            var urlString = $"https://v6.exchangerate-api.com/v6/02b11541d6d8a1486255b498/latest/{Enum.GetName(currencyType)}";
            using var webClient = new System.Net.WebClient();
            var json = webClient.DownloadString(urlString);
            var responseResult = JsonSerializer.Deserialize<ApiObj>(json);
            var result = new Dictionary<Currency, double>
            {
                {EUR, responseResult.ConversionRates.EUR * amountOfMoney},
                {RUB, responseResult.ConversionRates.RUB * amountOfMoney},
                {UAH, responseResult.ConversionRates.UAH * amountOfMoney},
                {USD, responseResult.ConversionRates.USD * amountOfMoney}
            };
            result.Remove(currencyType);
            return result;
        }

        public void PrintInfo()
        {
            ConversionRate.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
        }
    }

    public class ApiObj
    {
        public ConversionRate ConversionRates { get; set; }
    }

    public class ConversionRate
    {
        public double EUR { get; set; }
        public double RUB { get; set; }
        public double UAH { get; set; }
        public double USD { get; set; }
    }

    public enum Currency
    {
        EUR,
        RUB,
        UAH,
        USD
    }
}
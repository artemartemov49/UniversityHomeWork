using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.String;

namespace ParserUtils
{
    public class ParserUtil
    {
        public static readonly string ErrorText = "Oops... You entered inappropriate value. Try again";
        public static readonly Regex NameRegex = new(@"^\p{Lu}\p{L}*(?:[\s-]\p{Lu}\p{L}*)*$");

        public static string ValidateAndParseRegex(Regex regex, string value)
        {
            while (true)
            {
                Console.Write($"Input {value}: ");
                var readLine = Console.ReadLine();
                if (regex.IsMatch(readLine!))
                {
                    return readLine;
                }

                Console.WriteLine(ErrorText);
            }
        }

        public static string ValidateAndParseStringIsLetter(string valueName)
        {
            while (true)
            {
                Console.Write($"Enter {valueName}: ");
                var readLine = Console.ReadLine();
                if (readLine != null && readLine.ToCharArray().ToList().TrueForAll(char.IsLetter))
                {
                    return readLine;
                }

                Console.WriteLine(ErrorText);
            }
        }

        public static string ParseString(string valueName)
        {
            while (true)
            {
                Console.Write($"Enter {valueName}: ");
                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    return readLine;
                }

                Console.WriteLine(ErrorText);
            }
        }

        public static string ValidateAndParseExactWordList(string valueName, List<string> wordList)
        {
            while (true)
            {
                Console.Write($"Choose a {valueName} {Join(", ", wordList)}: ");
                var readLine = Console.ReadLine();
                if (readLine != null && wordList.Contains(readLine))
                {
                    return readLine;
                }

                Console.WriteLine(ErrorText);
            }
        }


        public static double ValidateAndParseDouble(string value)
        {
            while (true)
            {
                Console.Write($"Input {value}: ");
                var toParse = Console.ReadLine();
                if (toParse != null && double.TryParse(toParse, out var result))
                {
                    return result;
                }

                Console.WriteLine(ErrorText);
            }
        }

        public static double ValidateAndParseDoubleRange(string valueName, int from, int to)
        {
            while (true)
            {
                Console.Write($"Enter {valueName}: ");
                var readLine = Console.ReadLine();
                readLine = readLine?.Trim();
                if (readLine != null && double.TryParse(readLine, out var result) && result > from && result < to)
                {
                    return result;
                }

                Console.WriteLine(ErrorText);
            }
        }

        public static int ValidateAndParseInt(string valueName)
        {
            while (true)
            {
                Console.Write($"Enter {valueName} (have to be int): ");
                var readLine = Console.ReadLine();
                readLine = readLine?.Trim();
                if (readLine != null && int.TryParse(readLine, out var result))
                {
                    return result;
                }

                Console.WriteLine(ErrorText);
            }
        }

        public static int ValidateAndParseIntRange(string valueName, int from, int to)
        {
            while (true)
            {
                Console.Write($"Enter {valueName} (have to be int): ");
                var readLine = Console.ReadLine();
                readLine = readLine?.Trim();
                if (readLine != null && int.TryParse(readLine, out var result) && (result > @from && result < to))
                {
                    return result;
                }

                Console.WriteLine(ErrorText);
            }
        }
    }
}
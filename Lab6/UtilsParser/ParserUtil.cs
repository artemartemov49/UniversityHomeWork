using System;

namespace UtilsParser
{
    public static class ParserUtil
    {
        public static readonly string ErrorText = "Oops... You entered inappropriate value. Try again";


        public static int ValidateAndParseIntRange(string valueName, int from, int to)
        {
            while (true)
            {
                Console.Write($"Enter {valueName} (have to be int): ");
                var readLine = Console.ReadLine();
                readLine = readLine?.Trim();
                if (readLine != null && int.TryParse(readLine, out var result) && (result > @from && result <= to))
                {
                    return result;
                }

                Console.WriteLine(ErrorText);
            }
        }
    }
}
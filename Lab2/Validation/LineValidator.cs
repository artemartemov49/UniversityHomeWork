using System.Text.RegularExpressions;

namespace InputValidation
{
    public class LineValidator
    {
        public static bool IsCorrectRegex(Regex regex, string line)
        {
            return regex.IsMatch(line!);
        }

        public static bool IsDoubleLine(string line)
        {
            return double.TryParse(line, out _);
        }

        public static bool IsIntLine(Regex regex, string line)
        {
            return double.TryParse(line, out _);
        }

        public static bool IsNotEmptyString(Regex regex, string line)
        {
            return double.TryParse(line, out _);
        }
    }
}

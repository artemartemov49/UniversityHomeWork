using System.Text.RegularExpressions;

namespace Lab3
{
    class Validator
    { 
        public static readonly Regex Formula = new(@"^(?<FirstNumber>\d*\.?\d+|\d+\.?\d*)(?<CharSpliterator>[\/\-+*])?(?<SecondNumber>\d*\.?\d+|\d+\.?\d*)[=]?$");

        public static bool IsMatch(string line)
        {
            return Formula.IsMatch(line);
        }
    }
}

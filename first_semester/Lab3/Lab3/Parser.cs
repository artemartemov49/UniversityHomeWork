using System;
using System.Linq;

namespace Lab3
{
    class Parser
    {
        public static string ParseLine()
        {
            return RemoveWhitespace(Console.ReadLine());
        }

        private static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !char.IsWhiteSpace(c))
                .ToArray())
                .Replace(",",".");
        }
    }
}

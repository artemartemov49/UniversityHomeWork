using System;
using System.Text.RegularExpressions;
using static ParserUtils.ParserUtil;

namespace BookTask
{
    class BookExecute
    {
        public static readonly Regex ContentRegex = new Regex(@"[^\s]");

        static void Main(string[] args)
        {
            var author = new Author(ValidateAndParseRegex(NameRegex, "author"));
            var title = new Title(ValidateAndParseRegex(NameRegex, "title"));
            var content = new Content(ValidateAndParseRegex(ContentRegex, "content"));
            Book book = new Book(author, title, content);
            book.Show();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
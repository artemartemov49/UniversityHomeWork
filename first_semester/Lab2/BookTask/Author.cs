using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{
    class Author
    {
        private readonly string _authorName;

        public Author(string authorName)
        {
            _authorName = authorName;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Author name: " + _authorName);
        }
    }
}

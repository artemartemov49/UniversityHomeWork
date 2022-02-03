using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{
    class Content
    {
        private readonly string _contentInfo;

        public Content(string contentInfo)
        {
            _contentInfo = contentInfo;
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Content name: " + _contentInfo);
        }
    }
}
using System;

namespace BookTask
{
    class Title
    {
        private readonly string _titleName;

        public Title(string titleName)
        {
            _titleName = titleName;
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Title name: " + _titleName);
        }
    }
}

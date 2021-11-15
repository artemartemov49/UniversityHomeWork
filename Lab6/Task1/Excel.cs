using System;

namespace Task1
{
    public class Excel : AbstractHandler
    {
        public Excel(string fileName, string format) : base(fileName, format)
        {
        }

        public override void Create()
        {
            Console.WriteLine($"{Format} is creating");
        }

        public override void Delete()
        {
            Console.WriteLine($"{Format} is delete");
        }

        public override void Edit()
        {
            Console.WriteLine($"{Format} is edit");
        }

        public override void Open()
        {
            Console.WriteLine($"{Format} is open");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Docx : AbstractHandler
    {
        public Docx(string fileName, string format) : base(fileName, format)
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

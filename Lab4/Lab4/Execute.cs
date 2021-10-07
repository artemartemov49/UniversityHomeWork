using System;
using DebugInfoPrinter;

namespace Task1
{
    internal class Execute
    {
        static void Main(string[] args)
        {
            DebugPrinter.PrintArgumentsInfoInDebug(1, "AAAA", new Person() { Age = 4, Name = "Artem" });

            Console.WriteLine();
        }
    }
}

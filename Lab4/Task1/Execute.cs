using System;
using DebugInfoPrinter;
using Task2.Animals;

namespace Task2
{
    internal class Execute
    {
        static void Main(string[] args)
        {
            var bird = new Bird("Charlie");
            var dog = new Dog("Max", 4);
            var cat = new Cat("Milo");

            new DebugPrinter(bird,dog,cat).PrintPropInfoOfClasses();

            Console.WriteLine();
        }
    }
}

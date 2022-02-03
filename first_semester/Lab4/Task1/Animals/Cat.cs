using System;

namespace Task2.Animals
{
    internal class Cat : Animal
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        public override void Phrase()
        {
            Console.WriteLine("Meow, meow!");
        }
        public override void Eat()
        {
            Console.WriteLine($"Cat {Name} is eating!");
        }

        public override void Sleep()
        {
            Console.WriteLine($"Cat {Name} is sleeping!");
        }
    }
}

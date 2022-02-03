using System;

namespace Task2.Animals
{
    internal class Bird : Animal
    {
        public string Name { get; set; }

        public Bird(string name)
        {
            Name = name;
        }

        public override void Phrase()
        {
            Console.WriteLine($"Bird song {Name}!");
        }
        public override void Eat()
        {
            Console.WriteLine($"Bird eats {Name}!");
        }

        public override void Sleep()
        {
            Console.WriteLine($"The bird is sleeping {Name}!");
        }
    }
}

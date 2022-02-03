using System;

namespace Task2.Animals
{
    internal class Dog : Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override void Phrase()
        {
            Console.WriteLine("Woof woof!");
        }

        public override void Eat()
        {
            Console.WriteLine($"Dog {Name} is eating!");
        }

        public override void Sleep()
        {
            Console.WriteLine($"Dog {Name} is sleeping!");
        }
    }
}
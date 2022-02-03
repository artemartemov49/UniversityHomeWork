using System;
using DebugInfoPrinter;
using Task3.Cars;

namespace Task3
{
    internal class Execute
    {
        static void Main(string[] args)
        {
            var BMW = new Coupe("BMW", Color.Blue, 25_000);
            var Mercedes = new Sedan("Mercedes-Benz CLS", Color.Orange, 67_000);
            var Mazda = new SportCar("Mazda Miata", Color.Red, 58_000);

            new DebugPrinter(BMW, Mercedes, Mazda).PrintPropInfoOfClasses();

            Console.WriteLine();
        }
    }
}

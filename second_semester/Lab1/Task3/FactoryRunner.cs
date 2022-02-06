using static Task3.MyClass;

namespace Task3
{
    internal class FactoryRunner
    {
        static void Main(string[] args)
        {
            var ukraine = FactoryMethod<Country>("Ukraine", "UA");
            var country = FactoryMethod<Country>();
            Console.WriteLine();
        }
    }
}
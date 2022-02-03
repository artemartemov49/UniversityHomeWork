using System;

namespace Task4.MovieService
{
    class ApplicationLicense
    {
        private protected static void AllowTrial()
        {
            Console.WriteLine("Trial mode");
        }
        private protected static void AllowCommon()
        {
            Console.WriteLine("Free version");
        }
        private protected static void AllowPro()
        {
            Console.WriteLine("Paid version");
        }

        private protected static void WrongKey()
        {
            Console.WriteLine("Sorry! Your key is wrong so you have access for free version!");
        }
    }
}

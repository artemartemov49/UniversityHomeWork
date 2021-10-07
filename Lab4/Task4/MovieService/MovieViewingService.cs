using System;

namespace Task4.MovieService
{
    internal class MovieViewingService : ApplicationLicense
    {
        private Guid? Key { get; }

        public MovieViewingService(Guid licenseKey)
        {
            Key = licenseKey;

            FindKey();

        }
        private void FindKey()
        {
            if (Key == LicenseKey.Trial)
            {
                AllowTrial();
            }
            else if (Key == LicenseKey.Pro)
            {
                AllowPro();
            }
            else
            {
                WrongKey();
            }
        }

        public MovieViewingService()
        {
            AllowCommon();
        }

        public void WatchFilmTrailer()
        {
            Console.WriteLine("You are watching film trailer!");
        }

        public void WatchFilmInNormalQuality()
        {
            var isCorrectKey = Key == LicenseKey.Trial || Key == LicenseKey.Pro;
            Console.WriteLine(isCorrectKey
                ? "You are watching film in a normal quality!"
                : "Sorry! You don't have access to this service");
        }

        public void WatchFilmInGreatQuality()
        {
            Console.WriteLine(Key == LicenseKey.Pro
                ? "You are watching film in the best quality!"
                : "Sorry! You don't have access to this service");
        }

    }
}
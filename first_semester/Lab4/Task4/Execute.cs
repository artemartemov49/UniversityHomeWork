using System;
using Task4.MovieService;

namespace Task4
{
    class Execute
    {
        static void Main(string[] args)
        {
            new MovieViewingService().WatchFilmInGreatQuality();
            new MovieViewingService().WatchFilmInNormalQuality();
            new MovieViewingService().WatchFilmTrailer();
        }
    }
}

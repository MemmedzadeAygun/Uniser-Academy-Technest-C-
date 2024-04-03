using Polimorfizm.Classes;
using Polimorfizm.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm.Managers
{
    internal class MovieManager : IMovie
    {
        public Movie _movie;
        public MovieManager(Movie movie) 
        {
            _movie = movie;
        }
        public void Subtitles()
        {
            Console.WriteLine($"Name: {_movie.Name} yazi elave olundu");
        }

        public void Watching()
        {
            Console.WriteLine($"Id- {_movie.Id} -- {_movie.Name} , adli fim izlenmeye baslandi");
        }
    }
}

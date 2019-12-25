using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;
        static Repository()
        {
            _movies = new List<Movie>(){
                new Movie(){ Id=1, 
                Name="Shazam",
                ShortDescription="Shazaman des",
                ImageUrl="1.jpg" ,
                Description="<p> asgkasgasgg asfasf1111 saf sa fsaf saf saf afs</p>"},
                 new Movie(){ Id=2, 
                Name="Shaza2m",
                ShortDescription="Shazaman des2",
                ImageUrl="2.jpg" ,
                Description="<p> asgkasgasgg asfas22222f saf sa fsaf saf saf afs</p>"},
                 new Movie(){ Id=3, 
                Name="Shazam3",
                ShortDescription="Shazaman des3",
                ImageUrl="3.jpg" ,
                Description="<p> asgkasgasgg asfasf 33333saf sa fsaf saf saf afs</p>"},
                 new Movie(){ Id=4, 
                Name="Shazam4",
                ShortDescription="Shazaman de4s",
                ImageUrl="4.jpg" ,
                Description="<p> asgkasgasgg44444saf sa fsaf saf saf afs</p>"},
                 new Movie(){ Id=5, 
                Name="Shazam5",
               ShortDescription="Shazaman d5es",
                ImageUrl="5.jpg" ,
                Description="<p> asgkasga55555sf saf sa fsaf saf saf afs</p>"},
            
            };
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }
        // public static int DeleteMovie(int id)
    }
}
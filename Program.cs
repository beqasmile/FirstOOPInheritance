using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie(); // movie object

            DramaMovie movieDrama = new DramaMovie();
            ComedyMovie movieComedy = new ComedyMovie();
            ActionMovie movieAction = new ActionMovie();
            DocumentalMovie movieDoc = new DocumentalMovie();


            movieDrama.DramaticHeroName = "Robert De Niro";
            movieDrama.SetMovieName("Once upon a time in America");
            movieDrama.SetMovieLength (280);


            movieComedy.SetMovieName("Back 2 the future");
            movieComedy.NumberOfComicHeroes = 3;
            List<string> stunmenList = new List<string>();
            movieComedy.SetMovieLength(120);

            movieAction.SetMovieName("The best Action movie");
            stunmenList.Add("Michael Moor");
            stunmenList.Add("Andy Root");
            stunmenList.Add("Michael J Fox");
            movieAction.NameOfStuntmen = stunmenList;
            movieAction.SetMovieLength(150);

            movieDrama.SetMovieName("Ace of Base");
            List<string> dramaParts = new List<string>();
            dramaParts.Add("part 1");
            dramaParts.Add("part 2");
            dramaParts.Add("part 3");
            movieDrama.NameOfDramaticParts = dramaParts;
            movieDrama.SetMovieLength(30);


            DramaMovie movieDrama2 = new DramaMovie();

            movieDrama2.DramaticHeroName = "James Kameron";
            movieDrama2.SetMovieName("Back to reality");
            movieDrama2.SetMovieLength(150);



            Movie myFirstMovie = movieDrama;
            Movie mySecondMovie = movieComedy;
            Movie myThirdMovie = movieAction;
            Movie myFourthMovie = movieDrama2;


            Console.WriteLine(movieDrama.DramaticHeroName);
            // Console.WriteLine(myFirstMovie.DramaticHeroName); - compile error

         

            List<Movie> allMovies = new List<Movie>();
            allMovies.Add(myFirstMovie);
            allMovies.Add(mySecondMovie);
            allMovies.Add(myThirdMovie);
            allMovies.Add(myFourthMovie);

            List<Movie> allMovies1 = new List<Movie>();
            allMovies.Add(movieDrama);
            allMovies.Add(movieComedy);
            allMovies.Add(movieAction);
            allMovies.Add(movieDrama2);


            DramaMovie movieDramaNew = (DramaMovie) myFirstMovie;    // casting 
            ComedyMovie movieComedyNew = (ComedyMovie)mySecondMovie; // casting 
            ActionMovie movieActionNew = (ActionMovie)myThirdMovie; // casting 

            Console.WriteLine(movieDramaNew.DramaticHeroName);


            //DramaMovie movieDramaNewSecond = (DramaMovie)mySecondMovie; // runtime error

            if (myFirstMovie is DramaMovie)
            {
                DramaMovie movieDramaFirstMovie = (DramaMovie)myFirstMovie;
            }

            if (mySecondMovie is DramaMovie)
            {
                DramaMovie movieDramaFirstMovie = (DramaMovie)myFirstMovie;
            }

            


        }
    }
}

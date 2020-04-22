using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPInheritance
{
    public class Movie
    {
        private int movieID;
        private string movieName;
        private int movieLength;
        private int movieTicketPrice;
        private int movieAmoutOfTickets;
        private string movieType;
        //private string movieDirector;
        private FirstOOPInheritance.MovieDirector movieDirector;
        private List<MovieActor> movieActorsList;


       
        private int GetmovieTicketPrict()
        {
            return this.movieTicketPrice;
        }

        private void SetMovieTicketPrice(int ticketPrice)
        {
            this.movieTicketPrice = ticketPrice;
        }

        private int GetAmountOfTickets()
        {
            return this.movieAmoutOfTickets;
        }

        private void SetAmountOfTickets(int ticketAmount)
        {
            this.movieAmoutOfTickets = ticketAmount;
        }

        public int CalculateTotalRevenuOfTickets()
        {
            return this.movieAmoutOfTickets * this.movieTicketPrice;
        }


        public Movie()
        {
            this.movieID = 1;
            this.movieActorsList = new List<MovieActor>();
        }
        public Movie(int movieID)
        {
            this.movieID = movieID;
            this.movieActorsList = new List<MovieActor>();

        }


        public Movie( int movieID, string movie)
        {
            this.movieID = movieID;
            this.movieName = movie;
            this.movieActorsList = new List<MovieActor>();

        }

        public Movie(int movieID, string movie, int movieLength, string movieType, MovieDirector movieDirector)
        {
            this.movieID = movieID;
            this.movieName = movie;
            this.movieLength = movieLength;
            this.movieType = movieType;
            this.movieDirector = movieDirector;
            this.CalculateTypeOfTheMovie();
            this.movieActorsList = new List<MovieActor>();

        }



        private void CalculateTypeOfTheMovie()
        {
            if (this.movieLength > 200)
            {
                this.movieType = "Very Long";
            }
            else if (this.movieLength > 100 && this.movieLength <= 200)
            {
                this.movieType = "Long";
            }
            else if (this.movieLength <= 100 && this.movieLength >= 50)
            {
                this.movieType = "Average";
            }
            else
            {
                this.movieType = "Short";
            }
        }

        public MovieDirector GetMovieDirector()
        {
            return this.movieDirector;
        }
        public string GetMovieType()
        {
            return this.movieType;
        }
        public int GetMovieLength()
        {
            return this.movieLength;
        }
        public string GetMovieName()
        {
            return this.movieName;
        }
        public int GetMovieId()
        {
            return this.movieID;
        }

        public void SetMovieName(string movieName)
        {
            this.movieName = movieName;
        }

        public void SetMovieLength(int  movieLength)
        {
            this.movieLength = movieLength;
            this.CalculateTypeOfTheMovie();
        }
        public void SetMovieType(string movieType)
        {
            this.movieType = movieType;
        }
        public void SetMovieDirector(MovieDirector movieDirector)
        {
            this.movieDirector = movieDirector;
        }



        /// <summary>
        /// Add actor to the movies list
        /// </summary>
        /// <param name="movieActor"></param>
        public void AddActor(MovieActor movieActor)
        {
            bool actorFound = false;
            foreach (MovieActor item in this.movieActorsList)
            {
                if (item.Id == movieActor.Id)
                {
                    Console.WriteLine("Actor already exists and can not be added twice");
                    actorFound = true;
                }
            }
            if (!actorFound)
            {
                this.movieActorsList.Add(movieActor);

            }
        }

        /// <summary>
        /// Removes actor from the movies list
        /// </summary>
        /// <param name="actorId"></param>
        /// <returns></returns>
        public MovieActor RemoveActorByID(int actorId)
        
        {
            MovieActor actorToRemove = null;
            foreach (MovieActor item in this.movieActorsList)
            {
                if (item.Id == actorId)
                {
                    actorToRemove = item;
                }
            }

            if (actorToRemove!=null)
            {
                this.movieActorsList.Remove(actorToRemove);
            }

            return actorToRemove;

        }


        /// <summary>
        /// Find actor by its type
        /// </summary>
        /// <param name="actorType"></param>
        /// <returns></returns>
        public List<MovieActor> FindActorByType(string actorType)
        {
            List<MovieActor> actrorsByType = new List<MovieActor>();
            foreach (MovieActor item in this.movieActorsList)
            {
                if (item.ActorType == actorType)
                {
                    actrorsByType.Add(item);
                }
            }

            
            return actrorsByType;


        }



        /// <summary>
        /// Returns string representative of all Movie
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string movieActorListString = " Movie actors { ";
            foreach (MovieActor movieActor in this.movieActorsList)
            {
                movieActorListString = movieActorListString + " , " + movieActor.ToString();
                
            }

            movieActorListString = movieActorListString + "}";

            return "Movie name ->" + this.movieName +
                "\n Movie Length ->\r" + this.movieLength +
                "\n Movie ID ->" + this.movieID +
                "\n Movie type " + this.movieType +
                "\n Movie Director " + this.movieDirector.ToString() + movieActorListString;


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;
using VIACinemaDB.Model;

namespace VIACinemaDB
{
    class MovieFeeder
    {
        private TMDbClient client;
        public VIACinemaEntities Context { get;  set; }
       
        public MovieFeeder(string apiKey, VIACinemaEntities context)
        {
            Context = context;
            client = new TMDbClient(apiKey);
        }

        public async void getUpcommingMovies()
        {
            SearchContainerWithDates<SearchMovie> searchResultContainer = await client.GetMovieUpcomingListAsync();
            List<SearchMovie> searchResult = searchResultContainer.Results;

            foreach (SearchMovie searchMovie in searchResult)
            {

                if(searchMovie.OriginalLanguage.Contains("en"))
                {

                    Model.Movie movie = getMovieByID(searchMovie.Id);
                    Context.Movies.Add(movie);
                    Context.SaveChanges();
                    
                    Console.WriteLine(searchMovie.Title);
                    Console.WriteLine();
                }
            }
            
        }

        
        
        private Model.Movie getMovieByID(int id)
        {

            TMDbLib.Objects.Movies.Movie movie = client.GetMovieAsync(id, MovieMethods.Credits).Result;
            
            string imdb = movie.ImdbId;
            
            string movieTitle = movie.Title;

            int year = ((DateTime)movie.ReleaseDate).Year;
            
            string description = movie.Overview;
            
            List<Crew> c = movie.Credits.Crew;
            List<Cast> casts = movie.Credits.Cast;

            string directors = "";
            foreach (Crew crew in c)
            {
                if (crew.Job.Equals("Director"))
                {
                    directors += $"{crew.Name}, ";
                }

            }

            directors = directors.Substring(0, directors.Length - 2);
            
            string actors = "";
            foreach (Cast cast in casts)
            {
                if (cast.Order == 2)
                {
                    actors += $"{cast.Name}";
                    break;
                }
                actors += $"{cast.Name}, ";
            }
            int duration = (int)movie.Runtime;

            string imagePath = $"https://image.tmdb.org/t/p/w200{movie.PosterPath}";



            Model.Movie m = new Model.Movie()
            {
                imdb_id = imdb,
                name = movieTitle,
                year = year,
                description = description,
                director =directors,
                actor = actors,
                duration = duration,
                imageURL = imagePath,
                price = 10

            };

            return m;

        }

        //public void testGetMovieByID1(int id)
        //{
        //    TMDbLib.Objects.Movies.Movie movie = client.GetMovieAsync(id, MovieMethods.Credits).Result;

        //    Console.WriteLine("IMDB: {0}", movie.ImdbId);
        //    string imdb = movie.ImdbId;

        //    Console.WriteLine("Movie name: {0}", movie.Title);
        //    string movieTitle = movie.Title;

        //    int year = ((DateTime)movie.ReleaseDate).Year;
        //    Console.WriteLine("Year: {0}", year);

        //    Console.WriteLine("Description: {0}", movie.Overview);
        //    string description = movie.Overview;



        //    List<Crew> c = movie.Credits.Crew;
        //    List<Cast> casts = movie.Credits.Cast;

        //    string directors = "";
        //    foreach (Crew crew in c)
        //    {
        //        if (crew.Job.Equals("Director"))
        //        {
        //            directors += $"{crew.Name}, ";
        //        }

        //    }

        //    directors = directors.Substring(0, directors.Length - 2);
        //    Console.WriteLine("Director(s): {0}", directors);


        //    string actors = "";
        //    foreach (Cast cast in casts)
        //    {
        //        if (cast.Order == 2)
        //        {
        //            actors += $"{cast.Name}";
        //            break;
        //        }
        //        actors += $"{cast.Name}, ";
        //    }
        //    Console.WriteLine("Actors: {0}", actors);

        //    Console.WriteLine("Duration: {0}", movie.Runtime);
        //    int duration = (int)movie.Runtime;

        //    string imagePath = $"https://image.tmdb.org/t/p/w200{movie.PosterPath}";
        //    Console.WriteLine("Poster: {0}", imagePath);

        //    int price = 10;
        //    Console.WriteLine("Price: {0}", price);
        //}

    }
}

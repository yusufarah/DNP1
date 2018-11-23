using System;
using System.Collections.Generic;
using System.Linq;
using VIACinemaDB.Infrastructure.Repositories;
using VIACinemaDB.Model;

namespace VIACinemaDB.Persistence.Repositories
{
    internal class MovieRepository : Repository<Movie>, IMovieRepository
    {

        public MovieRepository(VIACinemaEntities context) : base(context)
        {
        }
        public VIACinemaEntities VIACinemaContext
        {
            get { return Context as VIACinemaEntities; }
        }

        public IEnumerable<Movie> GetAllScheduledMovies()
        {
            return VIACinemaContext.Movies
                .Join(
                VIACinemaContext.Schedules,
                m => m.movie_id,
                s => s.movie_id,
                (m, s) => new Movie()
                {
                    movie_id = m.movie_id,
                    name = m.name,
                    actor = m.actor,
                    description = m.description,
                    director = m.director,
                    duration = m.duration,
                    imageURL = m.imageURL,
                    imdb_id = m.imdb_id,
                    price = m.price,
                    Schedules = m.Schedules,
                    year = m.year
                }).ToList();
            //IEnumerable<Movie> movies = (from m in VIACinemaContext.Movies
            //              join s in VIACinemaContext.Schedules
            //              on m.movie_id equals s.movie_id
            //              where s.date_time.CompareTo(DateTime.Now) >= 1
            //              select m).ToList();
            //return movies;

        }
    }
}
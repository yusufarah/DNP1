
using System.Collections.Generic;
using VIACinemaDB.Model;

namespace VIACinemaDB.Infrastructure.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetAllScheduledMovies();
    }
}
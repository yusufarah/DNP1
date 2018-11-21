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
    }
}
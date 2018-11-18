using Queries.Core.Domain;
using Queries.Core.Repositories;
using Queries.Persistence.Repositories;
using System.Data.Entity;
using System.Linq;
using VIACinemaDB.Infrastructure.Repositories;
using VIACinemaDB.Model;

namespace VIACinemaDB.Persistence.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(VIACinemaEntities context) : base(context)
        {
        }
        

        public VIACinemaEntities VIACinemaContext
        {
            get { return Context as VIACinemaEntities; }
        }
    }
}
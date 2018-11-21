using VIACinemaDB.Infrastructure.Repositories;
using VIACinemaDB.Model;

namespace VIACinemaDB.Persistence.Repositories
{
    internal class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {

        public ScheduleRepository(VIACinemaEntities context) : base(context)
        {
        }

        public VIACinemaEntities VIACinemaContext
        {
            get { return Context as VIACinemaEntities; }
        }
    }
}
using VIACinemaDB.Infrastructure;
using VIACinemaDB.Infrastructure.Repositories;
using VIACinemaDB.Model;
using VIACinemaDB.Persistence.Repositories;

namespace VIACinemaDB.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VIACinemaEntities _context;

        public UnitOfWork(VIACinemaEntities context)
        {
            _context = context;
            Persons = new PersonRepository(_context);
            Reservations = new ReservationRepository(_context);
            Schedules = new ScheduleRepository(_context);
            Movies = new MovieRepository(_context);

        }

        public IPersonRepository Persons { get; private set; }
        public IReservationRepository Reservations { get; private set; }

        public IMovieRepository Movies { get; private set; }

        public IScheduleRepository Schedules { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
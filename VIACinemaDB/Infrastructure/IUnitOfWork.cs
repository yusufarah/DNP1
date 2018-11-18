using VIACinemaDB.Infrastructure.Repositories;
using System;

namespace VIACinemaDB.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Persons { get; }
        IReservationRepository Reservations { get; }
        int Complete();
    }
}
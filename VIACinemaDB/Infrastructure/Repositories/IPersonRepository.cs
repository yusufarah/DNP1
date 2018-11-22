
using System.Collections.Generic;
using VIACinemaDB.Model;

namespace VIACinemaDB.Infrastructure.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        int LastInsertedPersonID();
        int getPersonIDByEmail(string email);
    }
    
}
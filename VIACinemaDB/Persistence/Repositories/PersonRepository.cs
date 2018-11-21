
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VIACinemaDB.Infrastructure.Repositories;
using VIACinemaDB.Model;

namespace VIACinemaDB.Persistence.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(VIACinemaEntities context) 
            : base(context)
        {
        }
        

        public VIACinemaEntities VIACinemaContext
        {
            get { return Context as VIACinemaEntities; }
        }

        public int LastInsertedPersonID()
        {
            return VIACinemaContext.People.Count();
        }
    }
}
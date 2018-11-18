using Queries.Core.Domain;
using Queries.Core.Repositories;
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

        public IEnumerable<Person> GetTopSellingPersons(int count)
        {
            return VIACinemaEntities.Persons.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Person> GetPersonsWithAuthors(int pageIndex, int pageSize = 10)
        {
            return VIACinemaEntities.Persons
                .Include(c => c.Author)
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public VIACinemaEntities VIACinemaContext
        {
            get { return Context as VIACinemaEntities; }
        }
    }
}
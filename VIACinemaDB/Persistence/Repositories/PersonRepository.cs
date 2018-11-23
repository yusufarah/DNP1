
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

        public int getPersonIDByEmail(string email)
        {
            Person person = VIACinemaContext.People.SingleOrDefault(p => p.email == email);
            if (person == null)
            {
                person = new Person() { email = email };
                VIACinemaContext.People.Add(person);
                VIACinemaContext.SaveChanges();
            }
            return person.person_id;

        }

        public int LastInsertedPersonID()
        {
            return VIACinemaContext.People.Count();
        }
    }
}
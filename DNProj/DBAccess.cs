using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIACinemaDB.Infrastructure;
using VIACinemaDB.Model;
using VIACinemaDB.Persistence;

namespace DNProj
{
    public class DBAccess : IDBAccess
    {
        private IUnitOfWork unitOfWork;

        public DBAccess()
        {
            unitOfWork = new UnitOfWork(new VIACinemaEntities());
        }
        public IEnumerable<Movie> getAllMovies()
        {
            return unitOfWork.Movies.GetAll();
        }

        public void makeNewReservation(int seatNumber, int scheduleID, string email)
        {
            Reservation reservation = new Reservation()
            {
                seat_no = seatNumber,
                schedule_id = scheduleID,
                person_id = unitOfWork.Persons.getPersonIDByEmail(email)
            };

            unitOfWork.Reservations.Add(reservation);
            unitOfWork.Complete();


        }

        public Schedule updateSchedule(Schedule schedule)
        {
            return unitOfWork.Schedules.Get(schedule.schedule_id);
        }
    }
}

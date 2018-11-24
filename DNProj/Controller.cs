using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIACinemaDB.Model;

namespace DNProj
{
    class Controller
    {
        private List<Movie> movies = new List<Movie>();
        private DBAccess dBAccess = new DBAccess();

        public Controller()
        {
            movies = dBAccess.getAllMovies().ToList();
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public void addReservation(int seatNumber, int scheduleID, string email)
        {
            dBAccess.makeNewReservation(seatNumber, scheduleID, email);
        }

        public Schedule updateSchedule(Schedule schedule)
        {
            return dBAccess.updateSchedule(schedule);
        }

        public void updateDB()
        {
            movies.Clear();
            movies = dBAccess.getAllMovies().ToList();
        }
    }
}

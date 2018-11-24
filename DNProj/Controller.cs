using CheckoutEmailService;
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
        private MailService mailservice = new MailService("VIACinema2018@gmail.com");

        public Controller()
        {
            movies = dBAccess.getAllMovies().ToList();
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public void addReservation(int seatNumber, Schedule schedule, string email)
        {
            dBAccess.makeNewReservation(seatNumber, schedule.schedule_id, email);
            mailservice.sendBookingConfirmationTo(
                email,
                schedule.Movie.name,
                schedule.date_time,
                schedule.room,
                seatNumber,
                (decimal)schedule.Movie.price);
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

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
            //checks whether or not the email format is correct 
            if(mailservice.checkEmailFormat(email))
            {
                dBAccess.makeNewReservation(seatNumber, schedule.schedule_id, email);

                // there is two second delay to get email result
                Task<bool> sendConfirmation = 
                    mailservice.sendBookingConfirmationToAsync(
                    email,
                    schedule.Movie.name,
                    schedule.date_time,
                    schedule.room,
                    seatNumber,
                    (decimal)schedule.Movie.price); 

            
                // returns false if sending email failed
                // possibly the email address is invalid
                bool success = sendConfirmation.Result;
            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIACinemaDB.Util;
using VIACinemaDB.Infrastructure;
using VIACinemaDB.Model;
using VIACinemaDB.Persistence;
using CheckoutEmailService;

namespace TestVIADataBaseLib
{
    class Program
    {
        static void Main(string[] args)
        {



            //ScheduleGenerator scheduleGenerator = new ScheduleGenerator();
            //scheduleGenerator.GenerateSchedule();


            //IUnitOfWork unitOfWork = new UnitOfWork(new VIACinemaEntities());
            //var movies = unitOfWork.Movies.GetAllScheduledMovies();

            //foreach (Movie movie in movies)
            //{
            //    foreach (Schedule s in movie.Schedules)
            //    {
            //        Console.WriteLine("{0}, {1}, {2}, {3} ",
            //            s.schedule_id,
            //            s.date_time,
            //            s.room,
            //            movie.name);
            //    }
            //}

            //Schedule schedule1 = new Schedule()
            //{
            //    date_time = new DateTime(2018, 01, 25, 13, 50, 00),
            //    room = 12,
            //    movie_id = 3
            //};
            //unitOfWork.Schedules.Add(schedule1);
            //unitOfWork.Complete();


            //IDBAccess iDB = new DBAccess();
            //iDB.makeNewReservation(30, 1, "VIACINEMA2018@mail.com");

            ////get and add upcomming movies to database
            //var context = new VIACinemaEntities();
            //MovieFeeder feeder = new MovieFeeder("71e4cebd739f9f30aec016154250620f");
            //feeder.getUpcommingMovies();


            //creating a person object and inserting into database
            //var person1 = new Person()
            //{
            //    email = "VIACINEMA2018@mail.com",
            //    name = "person1"
            //};

            //unitOfWork.Persons.Add(person1);
            //unitOfWork.Complete();

            //Console.WriteLine(unitOfWork.Persons.LastInsertedPersonID());

            ////creating a movie object and inseting into database
            //var movie1 = new Movie()
            //{
            //    imdb_id = "tt12345",
            //    name = "Some Movie",
            //    year = 2000,
            //    description = "a movie for a special day",
            //    director = "some director who directed this with other directors",
            //    actor = "actor who could not resist showing off",
            //    duration = 150,
            //    imageURL = "link.com/to_movie_image.jpg",
            //    price = 10

            //};

            //unitOfWork.Movies.Add(movie1);
            //unitOfWork.Complete();


            //var movies = unitOfWork.Movies.GetAll();

            //foreach (var movie in movies)
            //{
            //    Console.WriteLine(movie.name);
            //}

            //context.Movies.Add(movie1);


            ////creating schedule for movie and saving into database
            //var schedule1 = new Schedule()
            //{
            //    room = 5,
            //    IMDB_id = "tt5523010",
            //    date_time = new DateTime(2018, 11, 20, 17, 00, 00)
            //};

            //context.Schedules.Add(schedule1);
            //context.SaveChanges();


            //creating reservation object and saving into database
            //var reservation = new Reservation()
            //{
            //    room = 5,
            //    IMDB_id = "tt5523010",
            //    date_time = new DateTime(2018, 11, 20, 17, 00, 00),
            //    email = "VIACINEMA2018@mail.com",
            //    seat_no = 22
            //};


            ////context.Reservations.Add(reservation1);
            ////context.SaveChanges();

            //Reservation savedReservation = context.Reservations.Where
            //    (
            //        c => c.room == reservation.room &&
            //        c.IMDB_id == reservation.IMDB_id &&
            //        c.date_time == reservation.date_time &&
            //        c.email == reservation.email &&
            //        c.seat_no == reservation.seat_no
            //    ).Single();



            //ICollection<Reservation> reservations = context.Reservations.ToList();
            //foreach (var reservation in reservations)
            //{
            //    var person = reservation.Person;
            //    var movie = reservation.Schedule.Movie;
            //    Console.WriteLine("Reservation");
            //    Console.WriteLine("Person name: {0}, email: {1}",
            //        person.name,
            //        person.email);
            //    Console.WriteLine("Movie name: {0}, imdb: {1}",
            //        movie.name,
            //        movie.imdb_id);
            //    Console.WriteLine("Day: {0}, time: {1}, Room: {2}, Seat: {3}",
            //        reservation.day,
            //        reservation.time,
            //        reservation.room,
            //        reservation.seat_no);
            //}


            MailService mailService = new MailService("VIACinema2018@gmail.com");
            string email = "alsdkfja1324@hotmail.com";
            if (mailService.checkEmailFormat(email))
            {
                Task<bool> sendConfirmation = mailService.sendBookingConfirmationToAsync(
                    email,
                    "abc",
                    DateTime.Now,
                    55,
                    123,
                    12);

                bool success = sendConfirmation.Result;
                Console.WriteLine("Sent: {0}", success);
            }
            else
            {
                Console.WriteLine("Bad email format");
            }
            Console.WriteLine("Done");
            Console.ReadKey();

        }
    }
}

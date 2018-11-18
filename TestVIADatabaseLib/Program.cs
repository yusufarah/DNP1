using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIACinemaDB;
using VIACinemaDB.Model;

namespace TestVIADataBaseLib
{
    class Program
    {
        static void Main(string[] args)
        {


            ////get and add upcomming movies to database
            var context = new VIACinemaEntities();
            //MovieFeeder feeder = new MovieFeeder("71e4cebd739f9f30aec016154250620f", context);
            //feeder.getUpcommingMovies();


            //creating a person object and inserting into database
            //var person1 = new Person()
            //{
            //    email = "VIACINEMA2018@mail.com",
            //    name = "person1"
            //};

            //context.People.Add(person1);
            //context.SaveChanges();


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

            Console.ReadKey();

        }
    }
}

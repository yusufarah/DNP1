using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VCinema();

            MovieFeeder feeder = new MovieFeeder("71e4cebd739f9f30aec016154250620f", context);

            feeder.getUpcommingMovies();

            Console.ReadKey();

            ////creating a person object and inserting into database
            //var person1 = new Person()
            //{
            //    email = "person1@mail.com",
            //    name = "person1"
            //};

            //context.People.Add(person1);


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

            //};

            //context.Schedules.Add(schedule1);


            ////creating reservation object and saving into database
            //var reservation1 = new Reservation()
            //{
            //    day = "Monday",
            //    time = 1700,
            //    room = 5,
            //    IMDB_id = "tt12345",
            //    email = "person1@mail.com",
            //    seat_no = "2A"
            //};

            //context.Reservations.Add(reservation1); 
            //context.SaveChanges();

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


        }
    }
}

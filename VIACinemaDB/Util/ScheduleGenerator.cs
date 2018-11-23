using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIACinemaDB.Infrastructure;
using VIACinemaDB.Model;
using VIACinemaDB.Persistence;

namespace VIACinemaDB.Util
{
    public class ScheduleGenerator
    {
        private IUnitOfWork unitOfWork;

        public ScheduleGenerator()
        {
            unitOfWork = new UnitOfWork(new VIACinemaEntities());
        }

        public void GenerateSchedule()
        {
            DateTime now = DateTime.Now;
            var movies = unitOfWork.Movies.GetAll();
            foreach (Movie movie in movies)
            {
                int numberOfDays = 1;
                
                DateTime dateTime = new DateTime(
                    now.Year,
                    now.Month,
                    now.Day,
                    10,
                    00,
                    00
                    );

                //for each movie
                //generating 30 days of schedule
                while(numberOfDays <= 30)
                {
                    Console.WriteLine("Day: {0}", numberOfDays);
                    //for each day 
                    //generating schedule between 10 and 22 o clock
                    while (dateTime.Hour < 22)
                    {
                        Schedule schedule = new Schedule()
                        {
                            date_time = dateTime,
                            room = movie.movie_id,
                            movie_id = movie.movie_id
                        };
                        unitOfWork.Schedules.Add(schedule);
                        Console.WriteLine("{0}, {1}, {2}",movie.name, dateTime, movie.movie_id);
                        dateTime = dateTime.AddHours(3);
                    }
                    dateTime = dateTime.AddHours(12);
                    numberOfDays += 1;
                    
                }
            }

            unitOfWork.Complete();
        }
    }
}

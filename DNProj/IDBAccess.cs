using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIACinemaDB.Model;

namespace DNProj
{
    interface IDBAccess
    {
        IEnumerable<Movie> getAllMovies();
        bool makeNewReservation(int seatNumber, int scheduleID, string email);

    }
}

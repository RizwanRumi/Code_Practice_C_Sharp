using System.Collections.Generic;
using System.Linq;

namespace HotelReservation.Model
{
    public class ReservationBook
    {
        private readonly List<Reservation> reservations;
        public ReservationBook()
        {
            reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return reservations.Where(r => r.UserName == username);
        }
    }
}

using HotelReservation.Exceptions;
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

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }

            reservations.Add(reservation);

        }
    }
}

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

        /// <summary>
        /// Get the reservation for a user
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns>the reservations for the user.</returns>
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return reservations.Where(r => r.UserName == username);
        }

        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="reservation"> The incoming reservation.</param>
        /// <exception cref="ReservationConflictException"></exception>
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

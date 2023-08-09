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
        /// Get all reservations.
        /// </summary>
        /// <returns>All reservations in the reservation book.</returns>
        public IEnumerable<Reservation> GetAllReservations()
        {
            return reservations;
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

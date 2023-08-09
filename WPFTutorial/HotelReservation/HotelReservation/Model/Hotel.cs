using System.Collections;
using System.Collections.Generic;

namespace HotelReservation.Model
{
    public class Hotel
    {
        private readonly ReservationBook reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            reservationBook = new ReservationBook();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return reservationBook.GetAllReservations();
        }

        public void MakeReservation(Reservation reservation)
        {
            reservationBook.AddReservation(reservation);
        }
    }
}
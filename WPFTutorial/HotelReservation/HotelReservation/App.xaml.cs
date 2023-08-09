using HotelReservation.Exceptions;
using HotelReservation.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelReservation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Ocean Life");
            try
            {                

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    "User 1",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 2)));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 1),
                    "User 1",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 4)));
            }
            catch (ReservationConflictException ex)
            {

            }
            

            IEnumerable<Reservation> reservations = hotel.GetAllReservations();

            base.OnStartup(e);
        }
    }
}

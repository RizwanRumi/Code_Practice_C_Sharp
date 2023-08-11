using HotelReservation.Commands;
using HotelReservation.Model;
using HotelReservation.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelReservation.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> ReservationList => _reservations;

        public ICommand MakeReservationCommand { get; }
        public ReservationListingViewModel(NavigationStore navigationStore, Func<MakeReservationViewModel> createViewModel) 
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand(navigationStore, createViewModel);

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1,2), "User 1", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 2), "User 2", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(5, 1), "User 3", DateTime.Now, DateTime.Now)));
        }
    }
}

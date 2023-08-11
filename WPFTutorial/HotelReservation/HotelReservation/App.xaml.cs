using HotelReservation.Exceptions;
using HotelReservation.Model;
using HotelReservation.Services;
using HotelReservation.Stores;
using HotelReservation.ViewModels;
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
        private readonly Hotel hotel;
        private readonly NavigationStore navigationStore;
        public App()
        {
            hotel = new Hotel("Ocean Sky");
            navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            navigationStore.CurrentViewModel = CreateMakeReservationViewModel();

            MainWindow = new MainWindow() 
            {
                DataContext = new MainViewModel(navigationStore)
            };

            MainWindow.Show(); 

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(hotel, new NavigationService(navigationStore, CreateReservationViewModel));
        }

        private ReservationListingViewModel CreateReservationViewModel() 
        {
            return new ReservationListingViewModel(hotel, new NavigationService(navigationStore, CreateMakeReservationViewModel));
        }

    }
}

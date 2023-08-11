using HotelReservation.Exceptions;
using HotelReservation.Model;
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
            navigationStore.CurrentViewModel = new ReservationListingViewModel(navigationStore);

            MainWindow = new MainWindow() 
            {
                DataContext = new MainViewModel(navigationStore)
            };

            MainWindow.Show(); 

            base.OnStartup(e);
        }
    }
}

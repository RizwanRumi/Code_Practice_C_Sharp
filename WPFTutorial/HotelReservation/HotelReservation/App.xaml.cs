using HotelReservation.Exceptions;
using HotelReservation.Model;
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
        public App()
        {
            hotel = new Hotel("Ocean Sky");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow() 
            {
                DataContext = new MainViewModel(hotel)
            };

            MainWindow.Show(); 

            base.OnStartup(e);
        }
    }
}

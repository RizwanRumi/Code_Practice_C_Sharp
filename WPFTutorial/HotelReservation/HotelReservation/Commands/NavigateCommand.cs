using HotelReservation.Stores;
using HotelReservation.ViewModels;

namespace HotelReservation.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        
        public NavigateCommand(NavigationStore navigationStore) 
        {
            _navigationStore = navigationStore;
        }
        
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new MakeReservationViewModel(new Model.Hotel(""));            
        }
    }
}

using MVVMTutorial.Model;
using MVVMTutorial.MVVM;
using System.Collections.ObjectModel;

namespace MVVMTutorial.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = "Property1",
                SerialNumber = "0001",
                Quantity = 5
            });

            Items.Add(new Item
            {
                Name = "Property2",
                SerialNumber = "0002",
                Quantity = 6
            });
            Items.Add(new Item
            {
                Name = "Property3",
                SerialNumber = "0003",
                Quantity = 7
            });
        }

        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            { 
                selectedItem = value;
                OnPropertyChanged();
            }
        }

       
    }
}

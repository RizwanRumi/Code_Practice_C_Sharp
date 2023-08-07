using MVVMTutorial.Model;
using MVVMTutorial.MVVM;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace MVVMTutorial.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }
        public RelayCommand AddCommand => new(execute => AddItem());
        public RelayCommand DeleteCommand => new(execute => DeleteItem(), canExecute => SelectedItem != null );
        public RelayCommand SaveCommand => new(execute => Save(), canExecute => CanSave() );
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
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

       private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "New Item",
                SerialNumber = "xxxx",
                Quantity = 0
            });

        }

        private void DeleteItem()
        {
            Items.Remove(selectedItem);
        }

        private void Save()
        {
            //save to file/db
        }

        private bool CanSave()
        {
            return true;
        }
    }
}

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        bool running = false;
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set 
            { 
                boundText = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
                OnPropertyChanged();
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Set From Code";
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //    private void btnToggle_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (running)
        //        {
        //            // stop
        //            tbStatus.Text = "Stopped";
        //            btnToggle.Content = "Run";
        //        }
        //        else
        //        {
        //            // run
        //            tbStatus.Text = "Running";
        //            btnToggle.Content = "Stop";
        //        }

        //        running = !running; 

        //    }
    }
}

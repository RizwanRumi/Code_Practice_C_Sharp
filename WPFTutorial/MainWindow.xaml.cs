using System.Windows;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();

            
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

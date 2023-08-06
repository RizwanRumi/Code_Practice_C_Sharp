using System.Windows;
using WPFTutorial.View.UserControls;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //DataContext = this;
            //entries = new ObservableCollection<string>();
            
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow(); 
            normalWindow.Show();
        }

        private void btnModal_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow modalWindow = new ModalWindow(this);
            Opacity = 0.4;
            modalWindow.ShowDialog();
            Opacity = 1;
            if(modalWindow.Success)
                txtInput.Text = modalWindow.Input;
        }

        //private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //private void btnMinimize_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void btnMaximize_Click(object sender, RoutedEventArgs e)
        //{
        //    if(WindowState == WindowState.Maximized) 
        //        WindowState = WindowState.Normal;
        //    else WindowState = WindowState.Maximized;
        //}

        //private void btnClose_Click(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}

        //private void btnDetails_Click(object sender, RoutedEventArgs e)
        //{
        //    expanderDetails.IsExpanded = !expanderDetails.IsExpanded;
        //}

        // private ObservableCollection<string> entries;

        //public ObservableCollection<string> Entries
        // {
        //     get { return entries; }
        //     set { entries = value; }
        // }


        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    Entries.Add(txtEntry.Text);
        //}

        //private void btnDelete_Click(object sender, RoutedEventArgs e)
        //{
        //    string selectedItem = (string)lvEntries.SelectedItem;
        //    Entries.Remove(selectedItem);
        //}

        //private void btnClear_Click(object sender, RoutedEventArgs e)
        //{
        //    Entries.Clear();
        //}

    }
}

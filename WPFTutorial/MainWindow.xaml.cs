﻿using Microsoft.Win32;
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

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Could not open file.", "ERROR!",MessageBoxButton.OK, MessageBoxImage.Error);
            MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement!", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Agreed";
            }
            else
            {
                tbInfo.Text = "Not Agreed";
            }
        }

        private void btnFileOpen_Click(object sender, RoutedEventArgs e) 
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# Source Files | *.cs";
            //fileDialog.InitialDirectory = "C:\\temp";
            fileDialog.Title = "Please select cs source(s) file...";
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            
            if(success == true)
            {
                string[] paths = fileDialog.FileNames;
                string[] fileNames = fileDialog.SafeFileNames;

                //tbInfo.Text = fileName;
            }
            else
            {
                // did not pick anything
            }
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

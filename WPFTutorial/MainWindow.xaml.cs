using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WinForms = System.Windows.Forms;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //DataContext = this;
            //entries = new ObservableCollection<string>();
            
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            expanderDetails.IsExpanded = !expanderDetails.IsExpanded;
        }

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

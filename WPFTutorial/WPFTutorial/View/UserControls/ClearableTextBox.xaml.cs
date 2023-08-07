using System.Windows;
using System.Windows.Controls;

namespace WPFTutorial.View.UserControls
{
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value;

                // do not do this!
                tblPlaceholder.Text = placeholder;
                //OnPropertyChanged()
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
                tblPlaceholder.Visibility = Visibility.Visible;
            else
                tblPlaceholder.Visibility = Visibility.Hidden;
        }
    }
}

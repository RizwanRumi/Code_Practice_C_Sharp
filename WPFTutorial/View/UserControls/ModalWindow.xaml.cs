using System.Windows;

namespace WPFTutorial.View.UserControls
{
    public partial class ModalWindow : Window
    {
        public bool Success { get; set; }
        public string Input { get; set; }

        public ModalWindow(Window parentWindow)
        {
            Owner = parentWindow;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = txtInput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInput.Text)) 
                btnOK.IsEnabled = true;
            else
                btnOK.IsEnabled = false;
        }
    }
}

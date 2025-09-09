using System.Windows;
using System.Windows.Controls;

namespace CMCSPrototype1.Views
{
    public partial class SubmitClaimPage : Page
    {
        public SubmitClaimPage()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim submitted (prototype only).");
        }

        private void ChooseFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("File chosen (prototype only).");
        }
    }
}

using System.Windows;
using System.Windows.Controls;

namespace CMCSPrototype1.Views
{
    public partial class VerifyClaimPage : Page
    {
        public VerifyClaimPage()
        {
            InitializeComponent();
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim approved (prototype only).");
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim rejected (prototype only).");
        }
    }
}

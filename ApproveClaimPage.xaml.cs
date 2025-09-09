using System.Windows;
using System.Windows.Controls;

namespace CMCSPrototype1.Views
{
    public partial class ApproveClaimPage : Page
    {
        public ApproveClaimPage()
        {
            InitializeComponent();
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            // Prototype behavior: show a message
            MessageBox.Show("Claim approved (prototype only).");
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            // Prototype behavior: show a message
            MessageBox.Show("Claim rejected (prototype only).");
        }
    }
}

using System.Windows;
using System.Windows.Controls;

namespace CMCSPrototype1.Views
{
    public partial class LecturerDashboard : Page
    {
        public LecturerDashboard()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Submit Claim page
            this.NavigationService.Navigate(new SubmitClaimPage());
        }

        private void ViewStatus_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Claim Status page
            this.NavigationService.Navigate(new ClaimStatusPage());
        }
    }
}

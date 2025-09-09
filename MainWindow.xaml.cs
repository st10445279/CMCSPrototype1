using System.Windows;
using CMCSPrototype1.Views;

namespace CMCSPrototype1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new SubmitClaimPage()); // Default page
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubmitClaimPage());
        }

        private void ClaimStatus_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClaimStatusPage());
        }

        private void VerifyClaim_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new VerifyClaimPage());
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ApproveClaimPage());
        }

        private void LecturerDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LecturerDashboard());
        }

        private void CoordinatorDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CoordinatorDashboard());
        }

        private void ManagerDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ManagerDashboard());
        }

    }
}

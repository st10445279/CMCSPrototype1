using System.Windows;
using System.Windows.Controls;

namespace CMCSPrototype1.Views
{
    public partial class ManagerDashboard : Page
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Approve Claim page
            this.NavigationService.Navigate(new ApproveClaimPage());
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reports displayed (prototype only).");
        }
    }
}

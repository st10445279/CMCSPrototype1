using System.Windows;
using System.Windows.Controls;

namespace CMCSPrototype1.Views
{
    public partial class CoordinatorDashboard : Page
    {
        public CoordinatorDashboard()
        {
            InitializeComponent();
        }

        private void ViewPending_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pending claims displayed (prototype only).");
        }

        private void Verify_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new VerifyClaimPage());
        }
    }
}


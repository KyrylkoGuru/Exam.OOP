using System.Windows;

namespace AuthApp
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ViewUsersButton_Click(object sender, RoutedEventArgs e)
        {
            UsersWindow usersWindow = new UsersWindow(MainWindow.Users);
            usersWindow.Show();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Закриваємо вікно адміністратора
        }
    }
}

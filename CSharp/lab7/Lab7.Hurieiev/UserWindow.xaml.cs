using System.Windows;

namespace AuthApp
{
    public partial class UserWindow : Window
    {
        public UserWindow(string userName)
        {
            InitializeComponent();
            WelcomeText.Text = $"Вітаємо тебе, {userName}!";
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Закриваємо вікно користувача
        }
    }
}

using System.Windows;

namespace AuthApp
{
    public partial class UsersWindow : Window
    {
        public UsersWindow(List<User> users)
        {
            InitializeComponent();
            UsersListBox.ItemsSource = users; // Встановлюємо список користувачів
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Закриваємо вікно
        }
    }
}

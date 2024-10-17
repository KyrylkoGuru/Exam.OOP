using System.Collections.Generic;
using System.Windows;

namespace AuthApp
{
    public partial class MainWindow : Window
    {
        public static List<User> Users = new List<User>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Register registerWindow = new Register();
            registerWindow.Show();
        }

        private void ShowUsersButton_Click(object sender, RoutedEventArgs e)
        {
            UsersWindow usersWindow = new UsersWindow(Users);
            usersWindow.Show();
        }
    }
}

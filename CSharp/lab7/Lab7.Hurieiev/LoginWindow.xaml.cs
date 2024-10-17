using System.Windows;

namespace AuthApp
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredName = NameTextBox.Text;
            string enteredPassword = PasswordBox.Password;

            bool isAuthenticated = false;

            foreach (var user in MainWindow.Users)
            {
                // Перевірка імені та пароля
                if (user.Name == enteredName && user.Password == enteredPassword)
                {
                    isAuthenticated = true;

                    // Відкриття нового вікна в залежності від ролі
                    if (user.Role == "Administrator")
                    {
                        AdminWindow adminWindow = new AdminWindow();
                        adminWindow.Show();
                    }
                    else
                    {
                        UserWindow userWindow = new UserWindow(user.Name);
                        userWindow.Show();
                    }

                    this.Close(); // Закриваємо вікно логіна
                    break;
                }
            }

            if (!isAuthenticated)
            {
                ErrorMessage.Text = "Що ви ввели не вірні дані";
            }
        }

        private void AdminLoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Введіть дані адміністратора
            string adminName = "admin"; // Ім'я адміністратора
            string adminPassword = "admin123"; // Пароль адміністратора

            string enteredName = NameTextBox.Text;
            string enteredPassword = PasswordBox.Password;

            if (enteredName == adminName && enteredPassword == adminPassword)
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                this.Close(); // Закриваємо вікно логіна
            }
            else
            {
                ErrorMessage.Text = "Невірне ім'я або пароль адміністратора.";
            }
        }
    }
}

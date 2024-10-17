using System.Windows;

namespace AuthApp
{
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            // Перевірка на заповненість полів
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ErrorMessage.Text = "Будь ласка, заповніть всі поля.";
                return;
            }

            // Додавання нового користувача до списку
            User newUser = new User(name, email, password, "RegularUser");
            MainWindow.Users.Add(newUser);
            MessageBox.Show("Реєстрація успішна! Ви можете увійти в систему.");
            this.Close(); // Закриваємо вікно реєстрації
        }
    }
}

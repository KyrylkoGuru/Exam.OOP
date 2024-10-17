using System.Windows;

namespace LAB7  
{
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow(string userName)
        {
            InitializeComponent();
            WelcomeMessage.Text = $"Вітаємо тебе, {userName}!";
        }
    }
}

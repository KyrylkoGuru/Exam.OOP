namespace lab6.Models
{
    public class User
    {
        public int Id { get; set; } // Ідентифікатор користувача
        public string FirstName { get; set; } // Ім'я
        public string LastName { get; set; } // Прізвище
        public string Email { get; set; } // Електронна адреса
        public DateTime RegistrationDate { get; set; } // Дата реєстрації
    }
}
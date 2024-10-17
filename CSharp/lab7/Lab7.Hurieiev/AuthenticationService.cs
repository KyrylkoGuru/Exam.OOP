using System.Collections.Generic;

namespace AuthApp
{
    public static class AuthenticationService
    {
        // Простий список користувачів для симуляції бази даних
        private static Dictionary<string, (string Name, string Password)> users = new Dictionary<string, (string, string)>();

        public static bool Register(string name, string email, string password)
        {
            if (!users.ContainsKey(email))
            {
                users[email] = (name, password);
                return true;
            }
            return false; // Користувач з такою електронною поштою вже існує
        }

        public static bool Login(string email, string password)
        {
            if (users.ContainsKey(email) && users[email].Password == password)
            {
                return true;
            }
            return false;
        }
    }
}

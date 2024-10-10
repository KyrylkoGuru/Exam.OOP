using lab6.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class UserRepository
{
    private const string FilePath = "users.json"; // Шлях до файлу

    public static List<User> LoadUsers()
    {
        if (!File.Exists(FilePath))
        {
            return new List<User>(); // Якщо файл не існує, повертаємо новий список
        }

        var json = File.ReadAllText(FilePath); // Читаємо дані з файлу
        return JsonSerializer.Deserialize<List<User>>(json); // Десеріалізуємо дані
    }

    public static void SaveUsers(List<User> users)
    {
        var json = JsonSerializer.Serialize(users); // Серіалізуємо список
        File.WriteAllText(FilePath, json); // Записуємо дані у файл
    }
}

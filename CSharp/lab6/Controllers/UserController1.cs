using lab6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab6.Controllers
{
    public class UserController : Controller
    {
        // Статичний список користувачів для зберігання в пам'яті
        private static List<User> users = UserRepository.LoadUsers(); // Завантаження користувачів з файлу

        // Метод для відображення списку користувачів
        public IActionResult Index()
        {
            return View(users);
        }

        // Метод для перегляду деталей користувача за Id
        public IActionResult Details(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // Метод для відображення форми створення нового користувача
        public IActionResult Create()
        {
            return View();
        }

        // Метод для обробки даних з форми створення
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1; // Генеруємо новий ID
                user.RegistrationDate = DateTime.Now;
                users.Add(user);
                UserRepository.SaveUsers(users); // Зберігаємо користувачів у файл
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // Метод для підтвердження видалення користувача
        public IActionResult Delete(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // Метод для виконання видалення
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
                UserRepository.SaveUsers(users); // Зберігаємо оновлений список у файл
            }
            return RedirectToAction("Index");
        }
    }
}
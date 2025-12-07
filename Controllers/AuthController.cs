using Microsoft.AspNetCore.Mvc;
using HotelMgm.Models;

namespace HotelManagement.Controllers
{
    public class AuthController : Controller
    {
        static List<User> users = new List<User>();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = users.FirstOrDefault(u =>
                u.Username == username && u.Password == password);

            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Username ose Password gabim!";
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            users.Add(user);
            return RedirectToAction("Login");
        }
    }
}

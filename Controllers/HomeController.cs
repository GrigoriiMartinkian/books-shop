using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        // Home page
        public IActionResult Index()
        {
            return View();
        }

        // About page
        public IActionResult About()
        {
            return View();
        }

        // Contacts page
        public IActionResult Contacts()
        {
            return View();
        }
    }
}

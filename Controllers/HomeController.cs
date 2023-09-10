using Microsoft.AspNetCore.Mvc;

namespace Smartphone_Shop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

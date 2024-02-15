using Microsoft.AspNetCore.Mvc;

namespace WebApp.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

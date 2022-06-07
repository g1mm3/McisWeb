using Microsoft.AspNetCore.Mvc;

namespace McisWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

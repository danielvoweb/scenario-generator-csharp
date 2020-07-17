using Microsoft.AspNetCore.Mvc;

namespace ScenarioGenerator.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

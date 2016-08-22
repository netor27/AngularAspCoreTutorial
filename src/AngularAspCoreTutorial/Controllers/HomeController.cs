using Microsoft.AspNetCore.Mvc;

namespace AngularAspCoreTutorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

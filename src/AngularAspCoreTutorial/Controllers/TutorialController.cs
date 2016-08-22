using Microsoft.AspNetCore.Mvc;

namespace AngularAspCoreTutorial.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Requirements()
        {
            return View();
        }

        public IActionResult CreateNewProject()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace NASAWebPrototype.Controllers
{
    public class SpaceMissionsController : Controller
    {
        public IActionResult SpaceMissions()
        {
            return View();
        }

        public IActionResult Apollo()
        {
            return View();
        }
    }
}

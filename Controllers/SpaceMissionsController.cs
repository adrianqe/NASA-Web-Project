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
        public IActionResult ManageSpaceMissions()
        {
            return View();
        }
        public IActionResult AddProject()
        {
            return View();
        }
        public IActionResult ProjectSelectedApollo()
        {
            return View();
        }
        public IActionResult ProjectSelectedGemini()
        {
            return View();
        }
    }
}

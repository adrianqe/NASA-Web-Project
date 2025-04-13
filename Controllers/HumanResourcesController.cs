using Microsoft.AspNetCore.Mvc;

namespace NASAWebPrototype.Controllers
{
    public class HumanResourcesController : Controller
    {
        public IActionResult Employees()
        {
            return View();
        }
    }
}

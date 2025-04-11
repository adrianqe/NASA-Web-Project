using Microsoft.AspNetCore.Mvc;

namespace NASAWebPrototype.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Modules()
        {
            return View();
        }
    }
}
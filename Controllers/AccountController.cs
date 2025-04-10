using Microsoft.AspNetCore.Mvc;

namespace NASAWebPrototype.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult LoginIris()
        {
            return View();
        }

        public ActionResult LoginFingerprint()
        {
            return View();
        }
    }
}

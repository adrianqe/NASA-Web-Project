using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace NASAWebPrototype.Controllers
{
    public class LocalizationDebugController : Controller
    {
        private readonly IStringLocalizer<LocalizationDebugController> _localizer;
        private readonly IViewLocalizer _viewLocalizer;

        public LocalizationDebugController(
            IStringLocalizer<LocalizationDebugController> localizer,
            IViewLocalizer viewLocalizer)
        {
            _localizer = localizer;
            _viewLocalizer = viewLocalizer;
        }

        public IActionResult Index()
        {
            ViewBag.CurrentCulture = CultureInfo.CurrentCulture.Name;
            ViewBag.CurrentUICulture = CultureInfo.CurrentUICulture.Name;

            // Intenta obtener algunas claves para probar
            ViewBag.HomeText = _localizer["Home"];
            ViewBag.SignInText = _localizer["SignIn"];

            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace NASAWebPrototype.Controllers
{
    public class ExperimentsController : Controller
    {
        public IActionResult Experiment()
        {
            return View();
        }
        public IActionResult SimulatingLifeOnMars()
        {
            return View();
        }
        public IActionResult ManageExperiments()
        {
            return View();
        }
        public IActionResult AddExperiments()
        {
            return View();
        }
        public IActionResult SelectedExperimentSimulatingLifeOnMars()
        {
            return View();
        }
        public IActionResult SelectedExperimentMoonwalks()
        {
            return View();
        }
    }
}

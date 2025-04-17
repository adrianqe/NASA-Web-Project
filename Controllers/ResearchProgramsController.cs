using Microsoft.AspNetCore.Mvc;

namespace NASAWebPrototype.Controllers
{
    public class ResearchProgramsController : Controller
    {
        public IActionResult ResearchProgram()
        {
            return View();
        }

		public IActionResult SpaceX()
		{
			return View();
		}
        public IActionResult ManageResearchPrograms()
        {
            return View();
        }
        public IActionResult AddResearchPrograms()
        {
            return View();
        }
        public IActionResult SelectedProgramSpaceX()
        {
            return View();
        }
        public IActionResult SelectedProgramNorthrop()
        {
            return View();
        }
        public IActionResult ProgramInformation()
        {
            return View();
        }
        public IActionResult InvestigatorsInCharge()
        {
            return View();
        }
        public IActionResult ResourceUsed()
        {
            return View();
        }
        public IActionResult ResultsAndPublications()
        {
            return View();
        }
    }
}


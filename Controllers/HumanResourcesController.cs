using Microsoft.AspNetCore.Mvc;
using NASAWebPrototype.Models;

namespace NASAWebPrototype.Controllers
{
    public class HumanResourcesController : Controller
    {
        public IActionResult Employees()
        {
            return View();
        }

        public IActionResult EmployeeInformation(int id/*,string section = "Employee"*/) {
            var model = new EmployeeInformationModel
            {
                //SectionToShow = section,
                IdEmployee = id
                // otros datos que necesites cargar
            }
            ;






            return View(model);

        }
    }
}

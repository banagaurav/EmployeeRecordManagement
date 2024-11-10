using Microsoft.AspNetCore.Mvc;
using RecordManagement.ViewModels;

namespace RecordManagement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public IActionResult Index()
        {
            return View();
        }

        //Get: Employee/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //POST: Employee/Add
        [HttpPost]
        public IActionResult Add(EmployeeViewModel model)
        {
            if (!ModelStat.IsValid)
            {
                return View(model);
            }
        }

    }
}

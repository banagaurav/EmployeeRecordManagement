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
            if (!ModelState.IsValid)
            {
                return View(model); // return to the form with validation errors
            }

            //Insert data in database
            return View(model);
        }

    }
}

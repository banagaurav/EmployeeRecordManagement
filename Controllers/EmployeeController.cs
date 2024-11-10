using Microsoft.AspNetCore.Mvc;

namespace RecordManagement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace RecordManagement.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: DepartmentController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string name)
        {
            return View();
        }
    }
}

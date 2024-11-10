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
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MedicalCenterPreclinic.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

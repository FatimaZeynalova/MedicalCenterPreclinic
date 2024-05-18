using Microsoft.AspNetCore.Mvc;

namespace MedicalCenterPreclinic.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

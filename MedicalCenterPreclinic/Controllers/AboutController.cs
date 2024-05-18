using Microsoft.AspNetCore.Mvc;

namespace MedicalCenterPreclinic.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

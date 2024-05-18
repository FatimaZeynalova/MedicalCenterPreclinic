using Microsoft.AspNetCore.Mvc;

namespace MedicalCenterPreclinic.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

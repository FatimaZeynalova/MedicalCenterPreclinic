using Microsoft.AspNetCore.Mvc;

namespace MedicalCenterPreclinic.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

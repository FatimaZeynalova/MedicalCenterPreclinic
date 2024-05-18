using Microsoft.AspNetCore.Mvc;

namespace MedicalCenterPreclinic.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

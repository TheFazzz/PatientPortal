using Microsoft.AspNetCore.Mvc;

namespace PatientPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace PatientPortal.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

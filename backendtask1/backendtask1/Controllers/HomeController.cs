using Microsoft.AspNetCore.Mvc;

namespace backendtask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

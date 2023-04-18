using Microsoft.AspNetCore.Mvc;

namespace backendtask1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

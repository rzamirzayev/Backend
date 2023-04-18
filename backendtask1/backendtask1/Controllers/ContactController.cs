using Microsoft.AspNetCore.Mvc;

namespace backendtask1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

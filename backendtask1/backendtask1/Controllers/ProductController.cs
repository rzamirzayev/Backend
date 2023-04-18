using Microsoft.AspNetCore.Mvc;

namespace backendtask1.Controllers
{
    public class ProductController : Controller
    {
        public ContentResult Detail(int id)
        {
            return Content(id.ToString());
        }
    }
}

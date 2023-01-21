using Microsoft.AspNetCore.Mvc;

namespace MVCday2.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MVCday2.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

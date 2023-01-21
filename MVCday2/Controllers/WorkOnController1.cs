using Microsoft.AspNetCore.Mvc;

namespace MVCday2.Controllers
{
    public class WorkOnController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

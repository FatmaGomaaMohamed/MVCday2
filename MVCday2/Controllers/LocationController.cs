using Microsoft.AspNetCore.Mvc;

namespace MVCday2.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

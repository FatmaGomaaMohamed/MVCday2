using Microsoft.AspNetCore.Mvc;
using MVCday2.Models;

namespace MVCday2.Controllers
{
    public class DependentController : Controller
    {
        private CompanyDbContext dbContext;
        public DependentController()
        {
            dbContext = new CompanyDbContext();
        }
    }
}

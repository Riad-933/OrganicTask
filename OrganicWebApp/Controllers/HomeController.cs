using Microsoft.AspNetCore.Mvc;

namespace OrganicWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

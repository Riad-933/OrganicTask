using Microsoft.AspNetCore.Mvc;

namespace OrganicWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace OrganicWebApp.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace OrganicWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

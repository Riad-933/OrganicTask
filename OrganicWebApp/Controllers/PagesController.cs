using Microsoft.AspNetCore.Mvc;
using OrganicWebApp.DAL;
using OrganicWebApp.ViewModels;

namespace OrganicWebApp.Controllers
{
    public class PagesController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public PagesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogGrid()
        {
            return View();
        }

        public IActionResult BlogDetail()
        {
            return View();
        }

        public IActionResult Features()
        {
            return View();
        }

        public IActionResult TheTeam()
        {
            PagesVM vm = new()
            {
                Farmers = _appDbContext.Farmers.ToList()
            };
            return View(vm);
        }

        public IActionResult Testimonial()
        {
            return View();
        }

    }
}

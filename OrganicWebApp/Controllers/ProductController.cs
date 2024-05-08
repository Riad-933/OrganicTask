using Microsoft.AspNetCore.Mvc;
using OrganicWebApp.DAL;
using OrganicWebApp.Models;
using OrganicWebApp.ViewModels;

namespace OrganicWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            ProductVM vm = new()
            {
                OrganicVegetables = _appDbContext.OrganicVegetables.ToList()
                
            };
            return View();
        }
    }
}

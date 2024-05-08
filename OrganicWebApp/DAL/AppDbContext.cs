using Microsoft.EntityFrameworkCore;
using OrganicWebApp.Models;

namespace OrganicWebApp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<OrganicVegetable> OrganicVegetables { get; set; }
        public DbSet<Farmer> Farmers { get; set; }


    }
}

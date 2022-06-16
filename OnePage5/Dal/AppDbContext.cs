using Microsoft.EntityFrameworkCore;
using OnePage5.Models;

namespace OnePage5.Dal
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<ToEat> toEat { get; set; }

        public DbSet<Catagory> catagories { get; set; }

    }
}

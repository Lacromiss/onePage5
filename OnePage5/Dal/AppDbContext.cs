using Microsoft.EntityFrameworkCore;
using OnePage5.Models;

namespace OnePage5.Dal
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        DbSet<Menu> menus { get; set; }
        DbSet<Sinif> sinifs { get; set; }



    }
}

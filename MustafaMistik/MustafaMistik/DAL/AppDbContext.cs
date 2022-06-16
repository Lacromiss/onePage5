using Microsoft.EntityFrameworkCore;
using MustafaMistik.Models;

namespace MustafaMistik.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
      public  DbSet<Catagory> catagories { get; set; }
    public    DbSet<MeetMenu> meetMenus { get; set; }
    }
}

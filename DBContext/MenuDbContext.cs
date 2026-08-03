using MenuAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MenuAPI.DBContext
{
    public class MenuDbContext : DbContext
    {

        public MenuDbContext(DbContextOptions<MenuDbContext> options) : base(options)
        {
            
        }

       
        public DbSet<Menu> Menus { get; set; }
    }
}

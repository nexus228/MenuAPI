using MenuAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MenuAPI.DBContext
{
    public class MenuDbContext : DbContext
    {

        public MenuDbContext(DbContextOptions<MenuDbContext> options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Day>()
                .Property(d => d.Date)
                .HasColumnType("timestamp without time zone");

            modelBuilder.Entity<Menu>()
                .Property(m => m.StartDate)
                .HasColumnType("timestamp without time zone");

            modelBuilder.Entity<Menu>()
                .Property(m => m.EndDate)
                .HasColumnType("timestamp without time zone");
        }

        public DbSet<Menu> Menus { get; set; }
    }
}

using MenuAPI.DBContext;
using MenuAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Globalization;

namespace MenuAPI.Repositories
{
    public class MenuRepository : IMenuRepository
    {

        private readonly MenuDbContext _context;

        public MenuRepository(MenuDbContext context)
        {
            _context = context;
        }

        

        public async Task<Menu> CreateMenuAsync(Menu menu)
        {
            List<Day> days = new List<Day>();

            for (DateTime date = menu.StartDate; date <= menu.EndDate; date = date.AddDays(1))
            {
                ///////////////////////////////////////////////////////////////////////
                /// create an empty day with empty meals for each day in the menu  ////
                ///////////////////////////////////////////////////////////////////////
                Day dayToAdd = new Day
                {
                    Date = date,
                    Name = date.ToString("dddd", new CultureInfo("de-DE"))
                };

                List<Meal> mealListForTheDay = new List<Meal>();
                mealListForTheDay.Add(new Meal { Name = string.Empty, Description = string.Empty, Identifier = MealIdentifier.Breakfast });
                mealListForTheDay.Add(new Meal { Name = string.Empty, Description = string.Empty, Identifier = MealIdentifier.Lunch });
                mealListForTheDay.Add(new Meal { Name = string.Empty, Description = string.Empty, Identifier = MealIdentifier.Dinner });

                dayToAdd.Meal = mealListForTheDay;

                days.Add(dayToAdd);
            }

            menu.Days = days;

            EntityEntry<Menu> entityEntry = await _context.Menus.AddAsync(menu);
            await _context.SaveChangesAsync();

            return entityEntry.Entity;
        }

        public async Task<bool> DeleteMenuAsync(int id)
        {
            bool returnValue = false;
            var menu = await _context.Menus.FindAsync(id);
            if (menu != null)
            {
                _context.Menus.Remove(menu);
                await _context.SaveChangesAsync();
                returnValue = true;
            }
            return returnValue;
        }

        public async Task<List<Menu>> GetAllMenusAsync()
        {
            List<Menu> menus = await _context.Menus.Include(m => m.Days).ThenInclude(d => d.Meal).ToListAsync();
            return menus;
        }

        public Task<Menu?> GetMenuByDateAsync(DateOnly date)
        {
            throw new NotImplementedException();
        }

        public Task<Menu?> GetMenuByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

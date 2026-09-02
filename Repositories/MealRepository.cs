using MenuAPI.DBContext;
using MenuAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MenuAPI.Repositories
{

    public class MealRepository : IMealRepository
    {

        private readonly MenuDbContext _context;

        public MealRepository(MenuDbContext context)
        {
            _context = context;
        }

        public async Task<Meal?> GetMealByIdAsync(int id)
        {
            return await _context.Meal.FindAsync(id);
        }

        public async Task<Meal?> UpdateMealAsync(Meal mealToUpdate)
        {
            var exists = await _context.Meal.AnyAsync(m => m.Id == mealToUpdate.Id);
            if (!exists)
                return null;


            EntityEntry<Meal> entityEntry = _context.Meal.Update(mealToUpdate);

            await _context.SaveChangesAsync();

            return entityEntry.Entity;
        }
    }
}

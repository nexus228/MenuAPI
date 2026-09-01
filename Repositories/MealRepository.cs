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

        public Task<Meal?> GetMealByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Meal?> UpdateMealAsync(Meal mealToUpdate)
        {
            EntityEntry<Meal> entityEntry = _context.Meals.Update(mealToUpdate);

            await _context.SaveChangesAsync();

            return entityEntry.Entity;
        }
    }
}

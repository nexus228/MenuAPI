using MenuAPI.Model;

namespace MenuAPI.Repositories
{
    public interface IMealRepository
    {
        Task<Meal?> GetMealByIdAsync(int id);
        Task<Meal> UpdateMealAsync(Meal meal);
    }
}

using MenuAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace MenuAPI.Repositories
{
    public interface IMealRepository
    {
        Task<Meal?> GetMealByIdAsync(int id);
        Task<Meal?> UpdateMealAsync(Meal meal);
    }
}

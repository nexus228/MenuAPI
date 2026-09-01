using MenuAPI.Model;
using MenuAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MenuAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealController : ControllerBase
    {
        private readonly IMealRepository _repository;

        public MealController(IMealRepository repository)
        {
            _repository = repository;
        }


        [HttpGet, Route("mealById/{id}")]
        public async Task<IActionResult> GetMeal(int id)
        {
            var meal = await _repository.GetMealByIdAsync(id);
            if (meal == null)
            {
                return NotFound();
            }
            return Ok(meal);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateMeal([FromBody] Meal meal)
        {
            if (meal == null)
            {
                return BadRequest();
            }
            var updatedMeal = await _repository.UpdateMealAsync(meal);
            return CreatedAtAction(nameof(UpdateMeal), new { id = updatedMeal.Id }, updatedMeal);
        }
    }
}

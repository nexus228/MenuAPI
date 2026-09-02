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


        [HttpGet("{id}")]
        public async Task<ActionResult<Meal>> GetMeal(int id)
        {
            var meal = await _repository.GetMealByIdAsync(id);
            if (meal == null)
                return NotFound();

            return Ok(meal);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Meal>> UpdateMeal(int id, [FromBody] Meal meal)
        {
            
            if (id != meal.Id)
                return BadRequest("Die ID in der URL stimmt nicht mit der ID im Body überein.");

            var updatedMeal = await _repository.UpdateMealAsync(meal);

            if (updatedMeal == null)
                return NotFound($"Meal mit ID {id} wurde nicht gefunden.");

            return Ok(updatedMeal);
        }
    }
}

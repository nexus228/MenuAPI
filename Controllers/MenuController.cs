using MenuAPI.Model;
using MenuAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MenuAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _repository;

        public MenuController(IMenuRepository repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("allMenus")]
        public async Task<IActionResult> GetMenus()
        {
            var menus = await _repository.GetAllMenusAsync();
            return Ok(menus);
        }

        [HttpGet, Route("menuById/{id}")]
        public async Task<IActionResult> GetMenu(int id)
        {
            var menu = await _repository.GetMenuByIdAsync(id);
            if (menu == null)
            {
                return NotFound();
            }
            return Ok(menu);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMenu([FromBody] Menu menu)
        {
            if (menu == null)
            {
                return BadRequest();
            }
            var createdMenu = await _repository.CreateMenuAsync(menu);
            return CreatedAtAction(nameof(GetMenu), new { id = createdMenu.ID }, createdMenu);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            bool deleted = await _repository.DeleteMenuAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }

}

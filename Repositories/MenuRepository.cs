using MenuAPI.DBContext;
using MenuAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MenuAPI.Repositories
{
    public class MenuRepository : IMenuRepository
    {

        private readonly MenuDbContext _context;

        public MenuRepository(MenuDbContext context)
        {
            _context = context;
        }

        

        public Task<Menu> CreateMenuAsync(Menu menu)
        {
            throw new NotImplementedException();
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
            return await _context.Menus.ToListAsync();
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

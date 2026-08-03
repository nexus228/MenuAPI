using MenuAPI.Model;

namespace MenuAPI.Repositories
{
    public interface IMenuRepository
    {
        Task<List<Menu>> GetAllMenusAsync();

        Task<Menu?> GetMenuByIdAsync(int id);

        Task<Menu?> GetMenuByDateAsync(DateOnly date);

        Task<Menu> CreateMenuAsync(Menu menu);

        Task<bool> DeleteMenuAsync(int id);
    }
}

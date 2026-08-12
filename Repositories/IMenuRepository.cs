using MenuAPI.Model;

namespace MenuAPI.Repositories
{
    public interface IMenuRepository
    {

        Task<List<Menu>> GetAllMenusAsync();

        Task<Menu?> GetMenuByIdAsync(int id);

        Task<Menu?> GetMenuByDateAsync(DateOnly date);

        /***
         * Create a new menu in the database.
         * @param menu The menu to create.
         * @return The created menu with its ID and internal creation of data like days and meals.
         */
        Task<Menu> CreateMenuAsync(Menu menu);

        Task<bool> DeleteMenuAsync(int id);
    }
}

using MenuAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace MenuAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        [HttpGet, Route("allMenus")]
        public IList<Menu> GetMenus()
        {
            IList<Menu> theMenuListToReturn = new List<Menu>();

            Menu menu = new Menu();
            menu.ID = 1;
            menu.StartDate = DateTime.Now;
            menu.Name = "Unser Speiseplan UPDATE 2";
            menu.Days = new List<Day>();
            theMenuListToReturn.Add(menu);

            menu = new Menu();
            menu.ID = 2;
            DateTime heute = DateTime.Now;
            DateTime in7Tagen = heute.AddDays(7);
            menu.StartDate = in7Tagen;
            menu.Name = "Unser Speiseplan UPDATE 2";
            menu.Days = new List<Day>();
            theMenuListToReturn.Add(menu);

            return theMenuListToReturn;
        }

        [HttpGet, Route("menuById/{id}")]
        public Menu GetMenu(int id)
        {
            Menu theMenuToReturn = new Menu();


            theMenuToReturn.Name = "Unser Speiseplan UPDATE 2";
            theMenuToReturn.Days = new List<Day>();

            return theMenuToReturn;
        }
    }

}

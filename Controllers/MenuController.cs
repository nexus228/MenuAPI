using MenuAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace MenuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {


        [HttpGet(Name = "GetMenu")]
        public Menu Get()
        {
            Menu theMenuToReturn = new Menu();


            theMenuToReturn.Name = "Unser Speiseplan UPDATE 2";
            theMenuToReturn.Days = new List<Day>();

            return theMenuToReturn;
        }
    }
}

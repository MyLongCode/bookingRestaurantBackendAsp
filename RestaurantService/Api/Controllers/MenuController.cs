using Api.Controllers.Menu.Requests;
using Logic.Menu.Interfaces;
using Logic.Menu.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("/menu")]
    public class MenuController : Controller
    {
        private readonly IMenuLogicManager _menuLogicManager;

        public MenuController(IMenuLogicManager menuLogicManager)
        {
            _menuLogicManager = menuLogicManager;
        }

        [HttpPost]
        [Route("/menu")]
        public IActionResult CreateMenu(CreateMenuRequest dto)
        {
            _menuLogicManager.CreateMenu(new MenuLogic
            {
                Name = dto.Name,
                RestaurantId = dto.RestaurantId,
            });
            return Ok("пацаны бэк 500 вернул");
        }
    }
}

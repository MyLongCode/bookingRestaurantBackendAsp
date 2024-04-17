using Api.Controllers.Restaurant.Requests;
using Api.Controllers.Restaurant.Responses;
using Api.Models;
using Humanizer;
using Logic.Category.Interfaces;
using Logic.Menu.Interfaces;
using Logic.Restaurant.Interfaces;
using Logic.Restaurant.Models;
using Logic.User.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Net;
using System.Security.Claims;

namespace Api.Controllers
{
    [Route("/restaurant")]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantLogicManager _restaurantLogicManager;
        private readonly IMenuLogicManager _menuLogicManager;
        private readonly ICategoryLogicManager _categoryLogicManager;
        private readonly IUserLogicManager _userLogicManager;

        public RestaurantController(IRestaurantLogicManager restaurantLogicManager,
            IMenuLogicManager menuLogicManager, ICategoryLogicManager categoryLogicManager, IUserLogicManager userLogicManager)
        {
            _restaurantLogicManager = restaurantLogicManager;
            _menuLogicManager = menuLogicManager;
            _categoryLogicManager = categoryLogicManager;
            _userLogicManager = userLogicManager;
        }
        /// <summary>
        /// Получить все рестораны
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/restaurant")]
        public IActionResult GetAllRestaurants([FromQuery] int page=1, Sort sort=Sort.IdAsc)
        {
            if (page <= 0) page = 1;
            var restaurants = _restaurantLogicManager.GetAllRestaurants(page, sort);
            return Ok(restaurants);
        }
        [HttpGet]
        [Route("/restaurant/{id}")]
        [ProducesResponseType(typeof(GetRestaurantResponse), 200)]
        public async Task<IActionResult> GetById(int id)
        {
            var restaurant = await _restaurantLogicManager.GetRestaurantInfo(id);
            var menus = await _menuLogicManager.GetAllMenusByRestaurantId(id);

            return Ok(new GetRestaurantResponse
            {
                Name = restaurant.Name,
                Address = restaurant.Address,
                OwnerId = restaurant.OwnerId,
                Description = restaurant.Description,
                Schedule = restaurant.Schedule,
                CapacityOnTable = restaurant.CapacityOnTable,
                Logo = restaurant.Logo,
                Preview = restaurant.Preview,
                Menus = menus.Select(m => new MenuDto
                {
                    Name = m.Name,
                    Categories = _categoryLogicManager.GetAllCategoriesByMenuId(m.Id)
                    .Result
                    .Select(c => new CategoryDto()
                    {
                        Name = c.Name,
                        Photo = c.Photo
                    }).ToArray()
                }).ToArray(),
            });
        }
        [Authorize]
        [HttpPost]
        [Route("/restaurant")]
        public IActionResult CreateRestaurant(CreateRestaurantRequest dto)
        {
            var ownerId = _userLogicManager.GetIdByUsername(User.Identity.Name).Result;
            var res = _restaurantLogicManager.CreateRestaurant(new RestaurantLogic
            {
                Name = dto.Name,
                Address = dto.Address,
                OwnerId = ownerId,
                Description = dto.Description,
                Schedule = dto.Schedule,
                CapacityOnTable = dto.CapacityOnTable,
                Logo = dto.Logo,
                Preview = dto.Preview
            });
            return Ok(res);
        }
        
    }
}

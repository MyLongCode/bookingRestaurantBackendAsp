using Api.Controllers.Restaurant.Requests;
using Logic.Restaurant.Interfaces;
using Logic.Restaurant.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace Api.Controllers
{
    [Route("/restaurant")]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantLogicManager _restaurantLogicManager;

        public RestaurantController(IRestaurantLogicManager restaurantLogicManager)
        {
            _restaurantLogicManager = restaurantLogicManager;
        }

        [HttpGet]
        [Route("/restaurant")]
        public IActionResult GetAllRestaurants()
        {
            var restaurants = _restaurantLogicManager.GetAllRestaurants();
            return Ok(restaurants);
        }

        [HttpGet]
        [Route("/restaurant/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_restaurantLogicManager.GetRestaurantInfo(id));
        }

        [HttpPost]
        [Route("/restaurant")]
        public IActionResult CreateRestaurant([FromBody] CreateRestaurantRequest dto)
        {
            var res = _restaurantLogicManager.CreateRestaurant(new RestaurantLogic
            {
                Name = dto.Name,
                Address = dto.Address,
                OwnerId = dto.OwnerId,
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

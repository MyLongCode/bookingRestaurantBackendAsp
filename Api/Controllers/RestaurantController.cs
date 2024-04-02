using Logic.Restaurant.Interfaces;
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

        public IActionResult Index()
        {
            return Ok(_restaurantLogicManager.GetRestaurantInfo(1));
        }
    }
}

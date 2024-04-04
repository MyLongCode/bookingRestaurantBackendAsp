﻿using Api.Controllers.Restaurant.Requests;
using Api.Controllers.Restaurant.Responses;
using Humanizer;
using Logic.Menu.Interfaces;
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
        private readonly IMenuLogicManager _menuLogicManager;

        public RestaurantController(IRestaurantLogicManager restaurantLogicManager,
            IMenuLogicManager menuLogicManager)
        {
            _restaurantLogicManager = restaurantLogicManager;
            _menuLogicManager = menuLogicManager;
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
                Menus = menus.ToArray(),
            });
        }

        [HttpPost]
        [Route("/restaurant")]
        public IActionResult CreateRestaurant(CreateRestaurantRequest dto)
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

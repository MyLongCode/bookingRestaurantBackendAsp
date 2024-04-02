﻿using Dal.EF;
using Dal.Menu.Models;
using Dal.Photo.Models;
using Dal.Restaurant.Interfaces;
using Dal.Restaurant.Models;
using Dal.User.Models;
using Logic.Restaurant.Interfaces;
using Logic.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Restaurant
{
    public class RestaurantLogicManager : IRestaurantLogicManager
    {

        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantLogicManager(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task CreateRestaurant(RestaurantLogic restaurant)
        { 
            await _restaurantRepository.CreateRestaurant(new RestaurantDal
            {
                Name = restaurant.Name,
                Address = restaurant.Address,
                OwnerId = restaurant.OwnerId,
                Description = restaurant.Description,
                Schedule = restaurant.Schedule,
                CapacityOnTable = restaurant.CapacityOnTable,
                Logo = restaurant.Logo,
                Preview = restaurant.Preview
            });
        }

        public Task DeleteRestaurantById(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RestaurantLogic>> GetAllRestaurants()
        {
            var result = await _restaurantRepository.GetAllRestaurants();
            return (IEnumerable<RestaurantLogic>)result;
        }

        public async Task<RestaurantLogic> GetRestaurantInfo(int restaurantId)
        {
            RestaurantDal restaurantDal = await _restaurantRepository.GetRestaurantInfo(restaurantId);
            return new RestaurantLogic
            {
                Name = restaurantDal.Name,
                Address=restaurantDal.Address,
                OwnerId=restaurantDal.OwnerId,
                Description=restaurantDal.Description,
                Schedule=restaurantDal.Schedule,
                CapacityOnTable=restaurantDal.CapacityOnTable,
                Logo=restaurantDal.Logo,
                Preview=restaurantDal.Preview
            };
        }

        public Task<string> GetRestaurantName(int restaurantId)
        {
            throw new NotImplementedException();
        }
    }
}
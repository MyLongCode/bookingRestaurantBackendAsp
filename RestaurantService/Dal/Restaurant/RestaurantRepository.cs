﻿using Dal.EF;
using Dal.Menu.Models;
using Dal.Photo.Models;
using Dal.Restaurant.Interfaces;
using Dal.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Dal.Restaurant
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private ApplicationDbContext db;

        public RestaurantRepository(ApplicationDbContext context) => this.db = context;
        public async Task CreateRestaurant(RestaurantDal restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        public Task DeleteRestaurantById(int restaurantId)
        {
            RestaurantDal restaurant = db.Restaurants.Find(restaurantId);
            if (restaurant == null)
                throw new Exception("restaurant undefined");
            db.Restaurants.Remove(restaurant);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<RestaurantDal>> GetAllRestaurants(int page)
        {
            int pageSize = 10;
            return db.Restaurants.Skip((page - 1)*pageSize).Take(pageSize).ToList();
        }

        public Task<RestaurantDal> GetRestaurantInfo(int restaurantId)
        {
            RestaurantDal restaurant = db.Restaurants.Find(restaurantId);
            if (restaurant == null)
                throw new Exception("restaurant undefined");
            return Task.FromResult(restaurant);
        }

        public Task<MenuDal[]> GetRestaurantMenuById(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRestaurantName(int restaurantId)
        {
            RestaurantDal restaurant = db.Restaurants.Find(restaurantId);
            if (restaurant == null)
                throw new Exception("restaurant undefined");
            return Task.FromResult(restaurant.Name);
        }

        public Task<PhotoDal[]> GetRestaurantPhotoById(int restaurantId)
        {
            throw new NotImplementedException();
        }
    }
}

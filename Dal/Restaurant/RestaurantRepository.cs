using Dal.Menu.Models;
using Dal.Photo.Models;
using Dal.Restaurant.Interfaces;
using Dal.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Restaurant
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public Task<int> CreateRestaurant(RestaurantDal restaurant)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRestaurantById(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public Task<RestaurantDal> GetRestaurantInfo(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public Task<MenuDal[]> GetRestaurantMenuById(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRestaurantName(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public Task<PhotoDal[]> GetRestaurantPhotoById(int restaurantId)
        {
            throw new NotImplementedException();
        }
    }
}

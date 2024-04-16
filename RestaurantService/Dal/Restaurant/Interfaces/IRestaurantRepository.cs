using Dal.Menu.Models;
using Dal.Photo.Models;
using Dal.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Dal.Restaurant.Interfaces
{
    public interface IRestaurantRepository
    {
        /// <summary>
        /// Получить все рестораны
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<RestaurantDal>> GetAllRestaurants(int page);
        /// <summary>
        /// Создание нового ресторана
        /// </summary>
        /// <param name="restaurant"></param>
        Task CreateRestaurant(RestaurantDal restaurant);
        /// <summary>
        /// Получить название ресторана по ID
        /// </summary>
        /// <param name="restaurantId"></param>
        /// <returns></returns>
        Task<string> GetRestaurantName(int restaurantId);
        /// <summary>
        /// Получить полную информацию о ресторане по ID
        /// </summary>
        /// <param name="restaurantId"></param>
        /// <returns></returns>
        Task<RestaurantDal> GetRestaurantInfo(int restaurantId);
        /// <summary>
        /// Удалить ресторан по ID
        /// </summary>
        /// <param name="restaurantId"></param>
        /// <returns></returns>
        Task DeleteRestaurantById(int restaurantId);
        /// <summary>
        /// Получить всё меню ресторана по ID
        /// </summary>
        /// <param name="restaurantId"></param>
        /// <returns></returns>
        Task<MenuDal[]> GetRestaurantMenuById(int restaurantId);
        /// <summary>
        /// Получить все фотографии ресторана по ID
        /// </summary>
        /// <param name="restaurantId"></param>
        /// <returns></returns>
        Task<PhotoDal[]> GetRestaurantPhotoById(int restaurantId);

    }
}

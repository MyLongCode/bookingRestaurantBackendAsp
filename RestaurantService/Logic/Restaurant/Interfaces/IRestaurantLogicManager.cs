using Logic.Restaurant.Models;

namespace Logic.Restaurant.Interfaces
{
    public interface IRestaurantLogicManager
    {
        /// <summary>
        /// Получить все рестораны
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<RestaurantLogic>> GetAllRestaurants();
        /// <summary>
        /// Создание нового ресторана
        /// </summary>
        /// <param name="restaurant"></param>
        Task CreateRestaurant(RestaurantLogic restaurant);
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
        Task<RestaurantLogic> GetRestaurantInfo(int restaurantId);
        /// <summary>
        /// Удалить ресторан по ID
        /// </summary>
        /// <param name="restaurantId"></param>
        /// <returns></returns>
        Task DeleteRestaurantById(int restaurantId);

    }
}

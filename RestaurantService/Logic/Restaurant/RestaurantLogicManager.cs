
using Dal.Restaurant.Interfaces;
using Dal.Restaurant.Models;
using Logic.Restaurant.Interfaces;
using Logic.Restaurant.Models;

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

        public async Task<IEnumerable<RestaurantLogic>> GetAllRestaurants(int page)
        {
            var result = await _restaurantRepository.GetAllRestaurants(page);
            return result.Select(a => new RestaurantLogic()
            {
                Name = a.Name,
                Address = a.Address,
                OwnerId = a.OwnerId,
                Description = a.Description,
                Schedule = a.Schedule,
                CapacityOnTable = a.CapacityOnTable,
                Logo = a.Logo,
                Preview = a.Preview
            });
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
            return _restaurantRepository.GetRestaurantName(restaurantId);
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Api.Controllers.Restaurant.Requests
{
    public record CreateRestaurantRequest
    {
        public string Name;
        public string Address;
        public int OwnerId;
        public string Description;
        public string Schedule;
        public int CapacityOnTable;
        public string Logo;
        public string Preview;
    }
}

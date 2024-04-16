using System.ComponentModel.DataAnnotations;

namespace Api.Controllers.Restaurant.Requests
{
    public record CreateRestaurantRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int OwnerId { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public int CapacityOnTable { get; set; }
        public string Logo { get; set; }
        public string Preview { get; set; }
    }
}

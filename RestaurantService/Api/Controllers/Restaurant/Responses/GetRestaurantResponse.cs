using Logic.Menu.Models;
using System.ComponentModel.DataAnnotations;

namespace Api.Controllers.Restaurant.Responses
{
    public record GetRestaurantResponse
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int OwnerId { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public int CapacityOnTable { get; set; }
        public string Logo { get; set; }
        public string Preview { get; set; }
        public MenuDto[] Menus { get; set; }
    }
    public record MenuDto
    {
        public string Name { get; set; }
        public CategoryDto[] Categories { get; set; }
    }
    public record CategoryDto
    {
        public string Name { get; set; }
        public string Photo { get; set; }
    }
}

namespace Api.Controllers.Menu.Requests
{
    public record CreateMenuRequest
    {
        public string Name { get; set; }
        public int RestaurantId { get; set; }
    }
}

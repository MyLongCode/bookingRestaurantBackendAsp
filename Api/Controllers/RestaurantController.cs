using Dal.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Authorize]
    [Route("/restaurant")]
    public class RestaurantController : Controller
    {
        ApplicationDbContext db;

        public RestaurantController(ApplicationDbContext db) => this.db = db;
        public IActionResult Index()
        {
            return Ok("пацаны бэк 500 вернул");
        }
    }
}

using Logic.Booking.Interfaces;
using Logic.User.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Authorize]
    [Route("/user")]
    public class UserController : Controller
    {
        IUserLogicManager _userLogicManager;
        IBookingLogicManager _bookingLogicManager;

        public UserController(IUserLogicManager userLogicManager, IBookingLogicManager bookingLogicManager)
        {
            _userLogicManager = userLogicManager;
            _bookingLogicManager = bookingLogicManager;
        }


    }
}

using Logic.Booking.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Filters;

namespace Api.Controllers
{
    [Route("/booking")]
    public class BookingController : Controller
    {
        private IBookingLogicManager _bookingLogicManager;
        public BookingController(IBookingLogicManager bookingLogicManager)
        {
            _bookingLogicManager = bookingLogicManager;
        }


    }
}

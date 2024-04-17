using Dal.Booking.Models;
using Logic.Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Booking.Interfaces
{
    public interface IBookingLogicManager
    {
        public Task CreateBooking(BookingLogic booking);
        public Task<IEnumerable<BookingLogic>> GetRestaurantBookings(int restaurantId);
        public Task<IEnumerable<BookingLogic>> GetUserBookings(int userId);
        public Task EditBookingStatus(int bookingId, string status);
    }
}

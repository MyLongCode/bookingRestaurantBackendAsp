using Dal.Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Booking.Interfaces
{
    public interface IBookingRepository
    {
        public Task CreateBooking(BookingDal booking);
        public Task<IEnumerable<BookingDal>> GetRestaurantBookings(int restaurantId);
        public Task<IEnumerable<BookingDal>> GetUserBookings(int userId);
        public Task EditBookingStatus(int bookingId, string status);
    }
}

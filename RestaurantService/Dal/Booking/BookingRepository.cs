using Dal.Booking.Interfaces;
using Dal.Booking.Models;
using Dal.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Booking
{
    public class BookingRepository : IBookingRepository
    {
        private ApplicationDbContext db;
        public BookingRepository(ApplicationDbContext context) => this.db = context;
        public async Task CreateBooking(BookingDal booking)
        {
            db.Bookings.Add(booking);
            db.SaveChanges();
        }

        public Task EditBookingStatus(int bookingId, string status)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookingDal>> GetRestaurantBookings(int restaurantId)
        {
            return db.Bookings.Where(b => b.RestaurantId == restaurantId).ToArray();
        }

        public async Task<IEnumerable<BookingDal>> GetUserBookings(int userId)
        {
            return db.Bookings.Where(b => b.UserId == userId).ToArray();
        }
    }
}

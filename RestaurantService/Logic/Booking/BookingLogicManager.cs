using Dal.Booking.Interfaces;
using Dal.Booking.Models;
using Dal.Category.Interfaces;
using Logic.Booking.Interfaces;
using Logic.Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Booking
{
    public class BookingLogicManager : IBookingLogicManager
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingLogicManager(IBookingRepository bookingRepository) => _bookingRepository = bookingRepository;
        public Task CreateBooking(BookingLogic booking)
        {
            _bookingRepository.CreateBooking(new BookingDal
            {
                PhoneNumber = booking.PhoneNumber,
                TableNumber = booking.TableNumber,
                Date = booking.Date,
                Status = booking.Status,
                CountPeople = booking.CountPeople,
                Wishes = booking.Wishes,
                UserId = booking.UserId,
                RestaurantId = booking.RestaurantId
            });
            return Task.CompletedTask;
        }

        public Task EditBookingStatus(int bookingId, string status)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookingLogic>> GetRestaurantBookings(int restaurantId)
        {
            return _bookingRepository.GetRestaurantBookings(restaurantId).Result.Select(booking => new BookingLogic
            {
                PhoneNumber = booking.PhoneNumber,
                TableNumber = booking.TableNumber,
                Date = booking.Date,
                Status = booking.Status,
                CountPeople = booking.CountPeople,
                Wishes = booking.Wishes,
                UserId = (int)booking.UserId,
                RestaurantId = (int)booking.RestaurantId
            }).ToArray();
        }

        public async Task<IEnumerable<BookingLogic>> GetUserBookings(int userId)
        {
            return _bookingRepository.GetUserBookings(userId).Result.Select(booking => new BookingLogic
            {
                PhoneNumber = booking.PhoneNumber,
                TableNumber = booking.TableNumber,
                Date = booking.Date,
                Status = booking.Status,
                CountPeople = booking.CountPeople,
                Wishes = booking.Wishes,
                UserId = (int)booking.UserId,
                RestaurantId = (int)booking.RestaurantId
            }).ToArray();
        }
    }
}

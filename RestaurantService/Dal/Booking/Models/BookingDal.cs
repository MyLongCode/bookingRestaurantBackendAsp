using Dal.Restaurant.Models;
using Dal.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Booking.Models
{
    public class BookingDal
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int TableNumber { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int CountPeople { get; set; }
        public string Wishes { get; set; }
        public int UserId { get; set; }
        public UserDal User { get; set; }
        public int RestaurantId { get; set; }
        public RestaurantDal Restaurant { get; set; }
    }
}

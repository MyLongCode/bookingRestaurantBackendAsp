
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Booking.Models
{
    public class BookingLogic
    {
        public string PhoneNumber { get; set; }
        public int TableNumber { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int CountPeople { get; set; }
        public string Wishes { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
    }
}

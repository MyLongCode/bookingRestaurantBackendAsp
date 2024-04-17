using Dal.Base;
using Dal.Booking.Models;
using Dal.User.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Restaurant.Models
{
    public record RestaurantDal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public UserDal User { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public int CapacityOnTable { get; set; }
        public string Logo { get; set; }
        public string Preview { get; set; }
    }
}

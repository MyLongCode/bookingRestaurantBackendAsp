using Dal.Base;
using System;
using System.Collections.Generic;
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
        public int OwnerId { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public int CapacityOnTable { get; set; }
        public byte[] Logo { get; set; }
        public byte[] Preview { get; set; }
    }
}

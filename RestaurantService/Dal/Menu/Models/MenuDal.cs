using Dal.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Menu.Models
{
    public class MenuDal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        public RestaurantDal Restaurant { get; set; }
    }
}

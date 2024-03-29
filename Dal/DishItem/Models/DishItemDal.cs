using Dal.Category.Models;
using Dal.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DishItem.Models
{
    public class DishItemDal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public string Compound { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
        public CategoryDal Category { get; set; }
    }
}

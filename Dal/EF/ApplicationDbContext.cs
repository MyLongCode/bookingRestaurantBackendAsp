using Dal.Category.Models;
using Dal.DishItem.Models;
using Dal.Menu.Models;
using Dal.Photo.Models;
using Dal.Restaurant.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dal.EF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<RestaurantDal> Restaurants{ get; set; }
        public DbSet<CategoryDal> Categories { get; set; }
        public DbSet<DishItemDal> DishItems { get; set; }
        public DbSet<MenuDal> Menus { get; set; }
        public DbSet<PhotoDal> Photos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

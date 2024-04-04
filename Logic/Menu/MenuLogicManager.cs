using Dal.EF;
using Dal.Menu.Interfaces;
using Dal.Menu.Models;
using Dal.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Menu
{
    public class MenuLogicManager : IMenuLogicManager
    {
        private ApplicationDbContext db;
        public MenuLogicManager(ApplicationDbContext context) => this.db = context;

        public async Task CreateMenu(MenuDal menu)
        {
            db.Menus.Add(menu);
            db.SaveChanges();
        }

        public Task DeleteMenu(int menuId)
        {
            MenuDal menu = db.Menus.Find(menuId);
            if (menu == null)
                throw new Exception("menu undefined");
            db.Menus.Remove(menu);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<MenuDal>> GetAllMenusByRestaurantId(int restaurantId)
        {
            return db.Menus.Where(m => m.RestaurantId == restaurantId).ToList();
        }

        public Task PatchMenu(MenuDal menu)
        {
            throw new NotImplementedException();
        }
    }
}

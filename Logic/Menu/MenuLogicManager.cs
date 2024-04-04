
using Dal.Menu.Interfaces;
using Dal.Menu.Models;
using Logic.Menu.Interfaces;
using Logic.Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Menu
{
    public class MenuLogicManager : IMenuLogicManager
    {
        private readonly IMenuRepository _menuRepository;

        public MenuLogicManager(IMenuRepository menuRepository) => _menuRepository = menuRepository;

        public Task CreateMenu(MenuLogic menu)
        {
            _menuRepository.CreateMenu(new MenuDal
            {
                Name = menu.Name,
                RestaurantId = menu.RestaurantId,
            });
            return Task.CompletedTask;
        }

        public Task DeleteMenu(int menuId)
        {
            _menuRepository.DeleteMenu(menuId);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<MenuLogic>> GetAllMenusByRestaurantId(int restaurantId)
        {
            var res = await _menuRepository.GetAllMenusByRestaurantId(restaurantId);
            return res.Select(m => new MenuLogic()
            {
                Name = m.Name,
                RestaurantId=m.RestaurantId,
            });
        }

        public Task PatchMenu(MenuLogic menu)
        {
            throw new NotImplementedException();
        }
    }
}

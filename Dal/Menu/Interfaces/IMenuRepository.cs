using Dal.Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Menu.Interfaces
{
    public interface IMenuRepository
    {
        /// <summary>
        /// Получить меню определённого ресторана по ID ресторана
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<MenuDal>> GetAllMenusByRestaurantId(int restaurantId);
        /// <summary>
        /// Создать новое меню
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public Task CreateMenu(MenuDal menu);
        /// <summary>
        /// Изменить меню
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public Task PatchMenu(MenuDal menu);
        /// <summary>
        /// Удалить меню по Id
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public Task DeleteMenu(int menuId);


    }
}

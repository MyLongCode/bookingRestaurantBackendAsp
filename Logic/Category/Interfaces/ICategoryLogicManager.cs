
using Logic.Category.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Category.Interfaces
{
    public interface ICategoryLogicManager
    {
        /// <summary>
        /// Получить меню определённого ресторана по ID ресторана
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<CategoryLogic>> GetAllCategoriesByMenuId(int menuId);
        /// <summary>
        /// Создать новое меню
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public Task CreateCategory(CategoryLogic category);
        /// <summary>
        /// Изменить меню
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public Task PatchCategory(CategoryLogic category);
        /// <summary>
        /// Удалить меню по Id
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public Task DeleteCategory(int categoryId);


    }
}

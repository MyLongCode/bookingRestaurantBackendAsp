
using Dal.Category.Models;

namespace Dal.Category.Interfaces
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Получить категории определённого меню по ID меню
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<CategoryDal>> GetAllCategoriesByMenuId(int menuId);
        /// <summary>
        /// Создать новою категорию
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public Task CreateCategory(CategoryDal category);
        /// <summary>
        /// Изменить категорию
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public Task PatchCategory(CategoryDal category);
        /// <summary>
        /// Удалить категорию по Id
        /// </summary>
        public Task DeleteCategory(int categoryId);


    }
}

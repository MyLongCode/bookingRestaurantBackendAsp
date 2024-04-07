using Dal.Category.Interfaces;
using Dal.Category.Models;
using Logic.Category.Interfaces;
using Logic.Category.Models;

namespace Logic.Category
{
    public class CategoryLogicManager : ICategoryLogicManager
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryLogicManager(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public Task CreateCategory(CategoryLogic category)
        {
            _categoryRepository.CreateCategory(new CategoryDal
            {
                Name = category.Name,
                MenuId = category.MenuId,
                Photo = category.Photo,
            });
            return Task.CompletedTask;
        }

        public Task DeleteCategory(int categoryId)
        {
            _categoryRepository.DeleteCategory(categoryId);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<CategoryLogic>> GetAllCategoriesByMenuId(int menuId)
        {
            var res = await _categoryRepository.GetAllCategoriesByMenuId(menuId);
            return res.Select(c => new CategoryLogic()
            {
                Name = c.Name,
                Photo = c.Photo,
                MenuId = c.MenuId,
            });
        }

        public Task PatchCategory(CategoryLogic category)
        {
            throw new NotImplementedException();
        }
    }
}

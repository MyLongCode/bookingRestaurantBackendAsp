using Dal.Category.Interfaces;
using Dal.Category.Models;
using Dal.EF;
using Dal.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext db;
        public CategoryRepository(ApplicationDbContext context) => this.db = context;

        public async Task CreateCategory(CategoryDal category)
        {
            db.Add(category);
            db.SaveChanges();
        }

        public Task DeleteCategory(int categoryId)
        {
            CategoryDal category = db.Categories.Find(categoryId);
            if (category == null)
                throw new Exception("Category undefined");
            db.Categories.Remove(category);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<CategoryDal>> GetAllCategoriesByMenuId(int menuId)
        {
            return db.Categories.Where(m => m.MenuId == menuId).ToList();
        }

        public Task PatchCategory(CategoryDal category)
        {
            throw new NotImplementedException();
        }
    }
}

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

        public Task CreateCategory(CategoryDal category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDal>> GetAllCategoriesByMenuId(int menuId)
        {
            throw new NotImplementedException();
        }

        public Task PatchCategory(CategoryDal category)
        {
            throw new NotImplementedException();
        }
    }
}

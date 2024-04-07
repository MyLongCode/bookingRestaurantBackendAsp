using Dal.Category;
using Dal.Category.Interfaces;
using Dal.Menu;
using Dal.Menu.Interfaces;
using Dal.Restaurant;
using Dal.Restaurant.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Logic
{
    public static class DalStartUp
    {
        public static IServiceCollection TryAddDal(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddScoped<IRestaurantRepository, RestaurantRepository>();
            serviceCollection.TryAddScoped<IMenuRepository, MenuRepository>();
            serviceCollection.TryAddScoped<ICategoryRepository, CategoryRepository>();
            return serviceCollection;
        }
    }
}

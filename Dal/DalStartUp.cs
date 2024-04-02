using Dal.Restaurant;
using Dal.Restaurant.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class DalStartUp
    {
        public static IServiceCollection TryAddDal(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddScoped<IRestaurantRepository, RestaurantRepository>();
            return serviceCollection;
        }
    }
}

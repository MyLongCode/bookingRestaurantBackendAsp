using Logic.Restaurant;
using Logic.Restaurant.Interfaces;
using Logic.Menu;
using Logic.Menu.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class LogicStartUp
    {
        public static IServiceCollection TryAddLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddScoped<IRestaurantLogicManager, RestaurantLogicManager>();
            serviceCollection.TryAddScoped<IMenuLogicManager, MenuLogicManager>();
            return serviceCollection;
        }
    }
}

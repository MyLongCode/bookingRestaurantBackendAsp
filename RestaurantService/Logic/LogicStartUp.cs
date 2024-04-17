using Logic.Restaurant;
using Logic.Restaurant.Interfaces;
using Logic.Menu;
using Logic.Menu.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Logic.Category;
using Logic.Category.Interfaces;
using Logic.User;
using Logic.User.Interfaces;
using Logic.Booking.Interfaces;
using Logic.Booking;

namespace Logic
{
    public static class LogicStartUp
    {
        public static IServiceCollection TryAddLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddScoped<IRestaurantLogicManager, RestaurantLogicManager>();
            serviceCollection.TryAddScoped<IMenuLogicManager, MenuLogicManager>();
            serviceCollection.TryAddScoped<ICategoryLogicManager, CategoryLogicManager>();
            serviceCollection.TryAddScoped<IUserLogicManager, UserLogicManager>();
            serviceCollection.TryAddScoped<IBookingLogicManager, BookingLogicManager>();

            return serviceCollection;
        }
    }
}

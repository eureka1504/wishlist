using Microsoft.Extensions.DependencyInjection;
using WishList.Application.Interfaces;
using WishList.Application.Services;

namespace WishList.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IGetWishListByIdService, GetWishListByIdService>();
            services.AddScoped<IGetWishListsByUserIdService, GetWishListsByUserIdService>();
            services.AddScoped<ICreateWishListService, CreateWishListService>();
            services.AddScoped<IGetBudgetByIdService, GetBudgetByIdService>();
            services.AddScoped<IGetBudgetByUserIdService, GetBudgetByUserIdService>();
            services.AddScoped<ICreateBudgetService, CreateBudgetService>();

            return services;
        }
    }
}

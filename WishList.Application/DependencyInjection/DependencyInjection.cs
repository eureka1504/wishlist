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
            services.AddScoped<IGetUserWishListsService, GetUserWishListsService>();
            services.AddScoped<ICreateWishListService, CreateWishListService>();

            return services;
        }
    }
}

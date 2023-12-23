
using Lab5.Application.Contracts.Clients;

namespace Lab5.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IUserService, ClientService>();
        collection.AddScoped<IShopService, ShopService>();

        collection.AddScoped<CurrentUserManager>();
        collection.AddScoped<ICurrentUserService>(
            p => p.GetRequiredService<CurrentUserManager>());

        return collection;
    }
}
using Lab5.Application.Contracts.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IUserService, UserService>();

        collection.AddScoped<CurrentClientManager>();
        collection.AddScoped<ICurrentClientService>(
            p => p.GetRequiredService<CurrentClientManager>());

        return collection;
    }
}
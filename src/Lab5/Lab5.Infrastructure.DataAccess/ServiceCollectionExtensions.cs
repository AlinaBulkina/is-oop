using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Models;
using Lab5.Application.Abstructions.Repositories;
using Lab5.Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Infrastructure.DataAccess;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureDataAccess(
        this IServiceCollection collection,
        Action<PostgresConnectionConfiguration> configuration)
    {
        collection.AddPlatformPostgres(builder => builder.Configure(configuration));
        collection.AddPlatformMigrations(typeof(ServiceCollectionExtensions).Assembly);

        collection.AddScoped<IAccountRepository, AccountRepository>();

        return collection;
    }
}
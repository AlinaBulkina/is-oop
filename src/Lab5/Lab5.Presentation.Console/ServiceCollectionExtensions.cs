using Lab5.Presentation.Console.Scenarios;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.Presentation.Console;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationConsole(this IServiceCollection collection)
    {
        collection.AddScoped<ScenarioRunner>();

        collection.AddScoped<IScenarioProvider, LoginAsUserScenarioProvider>();
        collection.AddScoped<IScenarioProvider, LoginAsAdminScenarioProvider>();
        collection.AddScoped<IScenarioProvider, AddAccountScenarioProvider>();

        return collection;
    }
}
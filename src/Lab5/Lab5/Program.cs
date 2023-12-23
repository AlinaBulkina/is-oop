using Lab5.Application;
using Lab5.Infrastructure.DataAccess;
using Lab5.Presentation.Console;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;

var collection = new ServiceCollection();

collection
    .AddApplication()
    .AddInfrastructureDataAccess(configuration =>
    {
        configuration.Host = "localhost";
        configuration.Port = 5432;
        configuration.Username = "postgres";
        configuration.Password = "postgres";
        configuration.Database = "postgres";
        configuration.SslMode = "Prefer";
    })
    .AddPresentationConsole();

ServiceProvider provider = collection.BuildServiceProvider();
using IServiceScope scope = provider.CreateScope();

ScenarioRunner scenarioRunner = scope.ServiceProvider
    .GetRequiredService<ScenarioRunner>();

while (true)
{
    await scenarioRunner.Run().ConfigureAwait(false);
    AnsiConsole.Clear();
}
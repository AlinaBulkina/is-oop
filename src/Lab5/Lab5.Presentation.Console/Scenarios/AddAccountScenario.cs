using Lab5.Application.Contracts.Clients;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios;

public class AddAccountScenario : IScenario
{
    private readonly IAdminService _adminService;

    public AddAccountScenario(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public string Name => "Add account";

    public Task Run()
    {
        long number = AnsiConsole.Ask<long>("Enter account number");
        long pin = AnsiConsole.Ask<long>("Enter account pin");
        _adminService.AddAccount(number, pin);
        AnsiConsole.WriteLine("Done");
        AnsiConsole.Ask<string>("Ok");
        return Task.CompletedTask;
    }
}
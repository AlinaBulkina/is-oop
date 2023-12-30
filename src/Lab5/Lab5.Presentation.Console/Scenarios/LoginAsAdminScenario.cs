using Lab5.Application.Contracts.Clients;
using Lab5.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios;

public class LoginAsAdminScenario : IScenario
{
    private readonly IAdminService _adminService;

    public LoginAsAdminScenario(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public string Name => "Login as admin";

    public async Task Run()
    {
        string systemPassword = AnsiConsole.Ask<string>("Enter system password");

        LoginResult result = await _adminService.Login(systemPassword).ConfigureAwait(false);

        string message = result switch
        {
            LoginResult.Success => "Successful login",
            LoginResult.WrongAccountNumberOrPin => "Wrong password",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("Ok");
    }
}
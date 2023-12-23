using Lab5.Application.Contracts.Clients;
using Lab5.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios;

public class LoginScenario : IScenario
{
    private readonly IUserService _userService;

    public LoginScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Login as user";

    public async Task<Task> Run()
    {
        string accountNumber = AnsiConsole.Ask<string>("Enter your account number");
        string pin = AnsiConsole.Ask<string>("Enter your pin");

        LoginResult result = await _userService.Login(accountNumber, pin).ConfigureAwait(false);

        string message = result switch
        {
            LoginResult.Success => "Successful login",
            LoginResult.WrongAccountNumberOrPin => "User not found",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("Ok");
        return Task.CompletedTask;
    }
}